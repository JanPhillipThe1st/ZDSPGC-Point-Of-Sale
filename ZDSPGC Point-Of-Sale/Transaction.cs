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
    public partial class Transaction : Form
    {
        Database database;
        InputUtilities inputUtilities;
        String updateID, updateName;
        public String cashier;
        Double transactionTotal = 0;
        public Transaction(String cashier)
        {
            this.cashier = cashier;
            database = new Database();
            inputUtilities = new InputUtilities();
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            suggestItems();
            tbBarcode.Focus();
        }

        private void tbItemDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                database.autoFillItemFromName(tbUnitPrice,tbBarcode,tbItemDescription.Text);
                tbQuantity.Text = "0";
                tbQuantity.Enabled = true;
                tbQuantity.Focus();
            }
        }

        private void tbBarcode_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            if(!inputUtilities.isValidQuantity(tbQuantity.Text, database.getCurrentItemQuantity(tbBarcode.Text))){
                tbQuantity.Clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbQuantity.Text == "" || tbQuantity.Text == "0")
            {
                MessageBox.Show("Please input quantity!");
            }
            else
            {
                database.updateQuantity(Convert.ToInt32(tbQuantity.Text),tbBarcode.Text);
                Double total = Convert.ToDouble(Convert.ToDouble(tbQuantity.Text)* Convert.ToDouble(tbUnitPrice.Text));
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvItems);
                row.Cells[0].Value = tbBarcode.Text;
                row.Cells[1].Value = tbItemDescription.Text;
                row.Cells[2].Value = tbUnitPrice.Text;
                row.Cells[3].Value = tbQuantity.Text;
                row.Cells[4].Value = (String.Format("{0:0.00}", total));
                dgvItems.Rows.Add(row);
                totalItems();
                inputUtilities.clearTextboxes(gbTransaction);
                tbBarcode.Focus();
            }
        }

        private void suggestItems() {
            AutoCompleteStringCollection items = new AutoCompleteStringCollection();
            tbItemDescription.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbItemDescription.AutoCompleteSource = AutoCompleteSource.CustomSource;
            items.AddRange(database.getProductsAsDictionary().Keys.ToArray<String>());
            tbItemDescription.AutoCompleteCustomSource = items;

            AutoCompleteStringCollection barcodes = new AutoCompleteStringCollection();
            tbBarcode.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbBarcode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            barcodes.AddRange(database.getProductsAsDictionary().Values.ToArray<String>());
            tbBarcode.AutoCompleteCustomSource = barcodes;
        }
        private void totalItems() {
            Double total = 0;
            foreach (DataGridViewRow item in dgvItems.Rows)
            {
              total +=  Convert.ToDouble(String.Format("{0:0.00}",item.Cells[4].Value));
            }
            if (inputUtilities.isIntegerNoMessage(total.ToString()))
            {
                lblTotal.Text = total.ToString() + ".00";
                transactionTotal = total;
            }
            else
            {
                lblTotal.Text = total.ToString();
                transactionTotal = total;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dgvItems_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void tbQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnConfirmSale.PerformClick();
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnAddToCredit.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                database.autoFillItemFromBarcode(tbItemDescription, tbUnitPrice, tbBarcode.Text);
                tbQuantity.Text = "0";
                tbQuantity.Enabled = true;
                tbQuantity.Focus();
            }
        }

        private void btnConfirmSale_Click(object sender, EventArgs e)
        {
            if (dgvItems.Rows.Count <= 0)
            {
                MessageBox.Show("Invalid Operation. No products in the table.");
                tbBarcode.Focus();
            }
            else { 
                Payment payment = new Payment(dgvItems, lblTotal.Text, cashier);
                payment.TopMost = true;
                payment.Show();
                
                
                lblTotal.Text = "00.00";
                tbBarcode.Focus();
            }
           
        }

        private void tbItemDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove '" + dgvItems.SelectedCells[1].Value.ToString() + "'? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                database.updateItem(Convert.ToInt32(dgvItems.SelectedCells[3].Value.ToString()), dgvItems.SelectedCells[0].Value.ToString());
                dgvItems.Rows.Remove(dgvItems.SelectedRows[0]);
                totalItems();
            }
        }

        private void tbQuantity_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnConfirmSale.PerformClick();
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnAddToCredit.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }

        private void btnAddToCredit_Click(object sender, EventArgs e)
        {
            if (dgvItems.Rows.Count <= 0)
            {
                MessageBox.Show("Invalid. Please add items first.");
                tbBarcode.Focus();
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to add this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    totalItems();
                    ChooseCustomer chooseCustomer = new ChooseCustomer(dgvItems,cashier);
                    chooseCustomer.TopMost = true;
                    chooseCustomer.Show();
                }
                lblTotal.Text = "00.00";
                tbBarcode.Focus();
            }
        }

        private void tbBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void addToTransaction() { 
        
        }
    }
}
