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
    public partial class Consignments : Form
    {
        Database database;
        InputUtilities inputUtilities;
        Double totalProfit;
        String updateID, updateName;
        public String cashier;

        public Consignments(String cashier)
        {
            this.cashier = cashier;
            database = new Database();
            inputUtilities = new InputUtilities();
            InitializeComponent();
        }

        private void Consignments_Load(object sender, EventArgs e)
        {
            database.fillConsignmentTable(dgvConsignments);
            getTotalProfit();

        }

        private void getTotalProfit()
        {
            totalProfit = 0;
            foreach (DataGridViewRow item in dgvConsignments.Rows)
            {
                totalProfit += Convert.ToDouble(item.Cells[9].Value);

            }
            lblProfit.Text = "Total Profit: " + totalProfit.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

           
        }

        private void tbOriginalPrice_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbUnitPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvConsignments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateName = dgvConsignments.SelectedCells[0].Value.ToString();
            updateID = database.getProductsAsDictionary()[updateName];
            if (MessageBox.Show("Are you sure you want to return '"+updateName+"'?","Please Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                ReceiptPrinting printer = new ReceiptPrinting(cashier,0);
                printer.printSoldConsignment(updateID,updateName, Convert.ToInt32(dgvConsignments.SelectedCells[7].Value), Convert.ToDouble(dgvConsignments.SelectedCells[2].Value), dgvConsignments.SelectedCells[6].Value.ToString());
                database.deleteConsignment(updateID);
                database.fillConsignmentTable(dgvConsignments);
                getTotalProfit();
            }
            else{ }

        }

        private void tbUpdateOriginalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUpdateUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUpdateQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        private void cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
