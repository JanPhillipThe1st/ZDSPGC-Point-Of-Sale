using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZDSPGC_Point_Of_Sale
{
    public partial class Add_Consignment : Form
    {
        Database database = new Database();
        InputUtilities inputUtilities = new InputUtilities();
        String barcode, itemDescription, unit;
        int quantity;
        Double originalPrice, unitPrice; 
        public Add_Consignment(String barcode, String itemDescription, String unit, Double originalPrice, Double unitPrice, int quantity)
        {
            this.barcode = barcode;
            this.itemDescription = itemDescription;
            this.unit = unit;
            this.originalPrice = originalPrice;
            this.unitPrice = unitPrice;
            this.quantity = quantity;

            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are you sure you want to add this item?","Please Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                database.addconsignment(barcode,itemDescription,unit,originalPrice,unitPrice,quantity,cbSupplier.Text,DateTime.Now);
                MessageBox.Show("Item Successfully Added to Consignments!");
            }
            else
            {

            }
        }
        private void Add_Consignment_Load(object sender, EventArgs e)
        {
            suggestItems();
        }
        private void suggestItems() {
            cbSupplier.Items.AddRange(database.getSuppliersAsDictionary("").Keys.ToArray<String>());
        }
    }
}
