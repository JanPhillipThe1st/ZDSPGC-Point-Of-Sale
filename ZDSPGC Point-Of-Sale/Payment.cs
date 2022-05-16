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
    public partial class Payment : Form
    {
        Database database;
        InputUtilities inputUtilities;
        Double transactionTotal = 0;
        ReceiptPrinting printer; 
        DataGridView data;
        Double price;
        public String cashier;
        public Payment(DataGridView data,String price,String cashier)
        {
            this.cashier = cashier;
            database = new Database();
            inputUtilities = new InputUtilities();
            this.price = Convert.ToDouble(price);
            this.data = data;
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            transactionTotal = 0;
            String[] items;
            int[] quantitties;
            Double[] itemAmount;
            ArrayList itemsArray =new ArrayList();
            ArrayList quantityArray =new ArrayList();
            ArrayList itemAmountArray =new ArrayList();
            if (tbPayment.Text != "")
            {
                if (Convert.ToDouble(tbPayment.Text) < price)
                {
                    MessageBox.Show("Insufficient Payment.");
                }
                else
                {
                    this.TopMost = false;
                    foreach (DataGridViewRow item in data.Rows)
                    {
                        itemsArray.Add(item.Cells[1].Value.ToString());
                        quantityArray.Add(Convert.ToInt32(item.Cells[3].Value));
                        itemAmountArray.Add(Convert.ToDouble(item.Cells[4].Value));
                        database.addSale(item.Cells[0].Value.ToString(),cashier, item.Cells[1].Value.ToString(), Convert.ToInt32(item.Cells[3].Value),database.getProductPrice(item.Cells[0].Value.ToString()), Convert.ToDouble(item.Cells[4].Value),database.getItemClassification(item.Cells[2].Value.ToString(),item.Cells[0].Value.ToString()));
                        database.updateSoldQuantity(Convert.ToInt32(item.Cells[3].Value), item.Cells[0].Value.ToString());
                    }
                    items = (String[])itemsArray.ToArray(typeof(String));
                    quantitties = (int[])quantityArray.ToArray(typeof(int));
                    itemAmount = (Double[])itemAmountArray.ToArray(typeof(Double));

                    printer = new ReceiptPrinting(cashier, Convert.ToDouble(tbPayment.Text));
                    printer.printReceipt(items,quantitties,itemAmount,database.getLastOR());

                    MessageBox.Show("Payment Success!\nThank you for Shopping.");
                    data.Rows.Clear();
                    this.Close();
                }
            }
            

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            tbPayment.Focus();
            lblPrice.Text = price.ToString();
            tbPayment.Text = "0";
        }


        private void tbPayment_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (!inputUtilities.isDouble(tbPayment.Text))
                {
                    tbPayment.Clear();
                }
                else
                {
                    if ((Convert.ToDouble(tbPayment.Text) - price) <= 0)
                    {
                        lblChange.Text = "00.00";
                    }
                    else
                    {
                        lblChange.Text = (Convert.ToDouble(tbPayment.Text) - price).ToString();
                    }
                    
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void tbPayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConfirm.PerformClick();
            }
        }
    }
}
