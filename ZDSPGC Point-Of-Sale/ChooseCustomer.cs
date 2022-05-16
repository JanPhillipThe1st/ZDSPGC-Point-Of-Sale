using System;
using System.Collections;
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
    public partial class ChooseCustomer : Form
    {
        public String cashier;
        DataGridView data;
        Database database;
        InputUtilities inputUtilities;
        Double transactionTotal = 0;
        public ChooseCustomer(DataGridView data, String cashier)
        {
            this.cashier = cashier;
            this.data = data;
            database = new Database();
            inputUtilities = new InputUtilities();
            InitializeComponent();
        }

        private void cbCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnConfirm.PerformClick();
            }
        }

        private void ChooseCustomer_Load(object sender, EventArgs e)
        {
            cbCustomers.Items.AddRange(database.getCustomersAsDictionary("").Keys.ToArray<String>());
        }
        private void totalItems()
        {
            Double total = 0;
            transactionTotal = 0;
            foreach (DataGridViewRow item in data.Rows)
            {
                transactionTotal += Convert.ToDouble(String.Format("{0:0.00}", item.Cells[4].Value));
            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbCustomers.Text == "")
            {
                MessageBox.Show("Invalid operation. Select Customer first.");
            }
            else
            {
                totalItems();
                String[] items;
                int[] quantitties;
                Double[] itemAmount;
                ArrayList itemsArray = new ArrayList();
                ArrayList quantityArray = new ArrayList();
                ArrayList itemAmountArray = new ArrayList();

                this.TopMost = false;
                int quantity = 0;
                foreach (DataGridViewRow item in data.Rows)
                {
                    itemsArray.Add(item.Cells[1].Value.ToString());
                    quantityArray.Add(Convert.ToInt32(item.Cells[3].Value));
                    itemAmountArray.Add(Convert.ToDouble(item.Cells[4].Value));
                    database.addCredit(item.Cells[0].Value.ToString(), cashier, item.Cells[1].Value.ToString(), Convert.ToInt32(item.Cells[3].Value), database.getProductPrice(item.Cells[0].Value.ToString()), Convert.ToDouble(item.Cells[4].Value));
                }
                items = (String[])itemsArray.ToArray(typeof(String));
                quantitties = (int[])quantityArray.ToArray(typeof(int));
                itemAmount = (Double[])itemAmountArray.ToArray(typeof(Double));
                database.addCredit(cbCustomers.Text, transactionTotal);
                MessageBox.Show("Credit Successfully Added!");
                data.Rows.Clear();
                this.Close();
            }
        }
    }
}
