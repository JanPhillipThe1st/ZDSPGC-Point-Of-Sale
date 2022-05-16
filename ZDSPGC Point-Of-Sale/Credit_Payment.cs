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
    public partial class Credit_Payment : Form
    {
        Database database;
        InputUtilities input;
        public Double credit;
        String customer;
        String cashier;
        public Credit_Payment(String cashier)
        {
            this.cashier = cashier;
            input = new InputUtilities();
            database = new Database();
            InitializeComponent();
        }

        private void Credit_Payment_Load(object sender, EventArgs e)
        {
            tbAmount.Focus();
            database.fillPaymentsTable(dgvPayments);
            database.fillCreditsTable(dgvCredits);
            database.fillCreditItemsTable(dgvCreditItems);
            lblCollectibles.Text = "Total Collectibles: "+ getTotalCollectibles().ToString("0.00");
        }


        private Double getTotalCollectibles() {
            Double totalCollectibles = 0;
            foreach (DataGridViewRow item in dgvCredits.Rows)
            {
                totalCollectibles += Convert.ToDouble(item.Cells[2].Value);
            }
            return totalCollectibles;
        }
        private void dgvCredits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            credit = Convert.ToDouble(dgvCredits.SelectedCells[2].Value);
            customer = Convert.ToString(dgvCredits.SelectedCells[0].Value);
            tbAmount.Focus();
            tbRemaining_Balance.Text = "0";
            tbAmount.Enabled = true;
            btnPay.Enabled = true;
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            if (input.isValidPayment(tbAmount.Text,credit))
            {
                tbRemaining_Balance.Text = (credit - Convert.ToDouble(tbAmount.Text)).ToString();
            }
            else
            {
                tbRemaining_Balance.Clear();
                tbAmount.Clear();
            }
            
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (tbAmount.Text == "")
            {
                MessageBox.Show("Invalid. Please select a Credit to Pay");
                tbAmount.Focus();
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to add this payment?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    database.payCredit(customer,Convert.ToDouble(tbAmount.Text));
                    database.addPayment(customer,Convert.ToDouble(tbAmount.Text), Convert.ToDouble(tbRemaining_Balance.Text));
                    database.addSale("--",cashier,"Credit Payment",0,0, Convert.ToDouble(tbAmount.Text),false);
                    MessageBox.Show("Credit Successfully Paid!");
                    database.fillPaymentsTable(dgvPayments);
                    database.fillCreditsTable(dgvCredits);
                }
                tbAmount.Enabled = false;
                btnPay.Enabled = false;
                lblCollectibles.Text = "Total Collectibles: "+ getTotalCollectibles().ToString("0.00");
            }
        }

        private void dgvCredits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
