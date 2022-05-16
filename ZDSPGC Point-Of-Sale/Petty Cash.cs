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
    public partial class Petty_Cash : Form
    {
        public String cashierName;
        Database database;
        InputUtilities input;
        public Petty_Cash(String cashierName)
        {
            input = new InputUtilities();
            database = new Database();
            this.cashierName = cashierName;
            InitializeComponent();
        }

        private void dgvPettyCash_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to add this record?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                try
                {
                    database.addPettyCash(cashierName, Convert.ToDouble(tbPettyCash.Text));
                    MessageBox.Show("Petty Cash Added Successfully!");
                    database.fillPettyCashTable(dgvPettyCash, cashierName);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {

            }
        }

        private void Petty_Cash_Load(object sender, EventArgs e)
        {
            database.fillPettyCashTable(dgvPettyCash, cashierName);
        }

        private void tbPettyCash_TextChanged(object sender, EventArgs e)
        {
            if(!input.isDouble(tbPettyCash.Text)){
                tbPettyCash.Clear();
            }
            else
            {
                if (Convert.ToDouble(tbPettyCash.Text) >= 100)
                {
                    MessageBox.Show("Petty Cash Cannot Exceed 100 pesos!");
                    tbPettyCash.Clear();
                }
            }
        }
    }
}
