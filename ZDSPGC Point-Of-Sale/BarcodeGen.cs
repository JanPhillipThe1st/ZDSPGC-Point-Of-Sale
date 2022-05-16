using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronBarCode;

namespace ZDSPGC_Point_Of_Sale
{
    public partial class BarcodeGen : Form
    {
        Database database;
        String barcodeString1 = "00000000";
        public BarcodeGen()
        {
            database = new Database();
            InitializeComponent();
            
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
           String path1= System.IO.Path.Combine(path,barcodeString1);
            GeneratedBarcode MyBarCode = IronBarCode.BarcodeWriter.CreateBarcode(barcodeString1, BarcodeWriterEncoding.Code128);
            MyBarCode.SaveAsPng(path1);

            database.addBarcode(barcodeString1,path1);
            database.fillBarcodesTable(dgvBarcodes);
            MessageBox.Show("Barcode Successfully Added!");

            getCurrentBarcode();
            label1.Text = "Current Barcode: " + barcodeString1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarcodeGen_Load(object sender, EventArgs e)
        {
            database.fillBarcodesTable(dgvBarcodes);
            getCurrentBarcode();
            label1.Text = "Current Barcode: " + barcodeString1;
        }
        private void getCurrentBarcode() {
            Int32 currentBarcode = Convert.ToInt32(database.getLastBarcode());
            String finalBarcode = "", barcodeString = "", bc = "";
            currentBarcode += 1;
            barcodeString = String.Format("{0,8}", currentBarcode.ToString());
            finalBarcode = ReverseString(barcodeString);
            foreach (Char item in finalBarcode)
            {
                if (item == ' ')
                {
                    bc += '0';
                }
                else
                {
                    bc += item;
                }
            }
            barcodeString1 = ReverseString(bc);

        }
        public static string ReverseString(string myStr)
        {
            char[] myArr = myStr.ToCharArray();
            Array.Reverse(myArr);
            return new string(myArr);
        }
        private void dgvBarcodes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBoxBarcode.BackgroundImage = Image.FromFile(dgvBarcodes.SelectedCells[1].Value.ToString());
            lblPlaceholder.Text= dgvBarcodes.SelectedCells[0].Value.ToString();
        }
    }
}
