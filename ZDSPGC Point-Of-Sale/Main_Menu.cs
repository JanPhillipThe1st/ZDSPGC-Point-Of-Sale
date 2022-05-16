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
    public partial class Main_Menu : Form
    {
        public bool isAdmin;
        public String cashier;
        FormUtilities formUtilities;
        Database database;
        public Main_Menu(bool isAdmin,String cashier)
        {
            this.cashier = cashier;
            database = new Database();
            formUtilities = new FormUtilities(this);
            this.isAdmin = isAdmin;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                this.Close();
            }
            else
            {
                logOut();
            }
        }
        private void logOut() {
            try
            {
                if (MessageBox.Show("Are you sure you want to log out?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("You are logging out...\nYour total sales for today is: " + database.getSalesLogout(cashier).ToString() + "\nAnd your petty cash is: " + database.getPettyCashLogout(cashier).ToString());
                    this.Close();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(isAdmin,cashier) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formUtilities.replaceControls(panelDisplay,dashboard);
        }

        private void Main_Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnDashboard.PerformClick();
            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction(cashier) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formUtilities.replaceControls(panelDisplay, transaction);
        }

        private void btnConsignments_Click(object sender, EventArgs e)
        {
            
            Consignments consignment = new Consignments("Admin") { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formUtilities.replaceControls(panelDisplay, consignment);
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            Credit credit = new Credit(cashier) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formUtilities.replaceControls(panelDisplay, credit);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formUtilities.replaceControls(panelDisplay, inventory);
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            bigAssTextBox.Focus();
            btnDashboard.PerformClick();
            if (isAdmin)
            {
                btnTransaction.Hide();
                btnCredits.Hide();
                btnPettyCash.Hide();
                
            }
            else
            {
                btnCredits.Hide();
                btnConsignments.Hide();
                btnSettings.Hide();
                btnStaff.Hide();
                btnInventory.Hide();
            }
           
        }

        private void Staff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formUtilities.replaceControls(panelDisplay, staff);
        }

        private void btnPettyCash_Click(object sender, EventArgs e)
        {
            Petty_Cash pettyCash = new Petty_Cash(cashier) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formUtilities.replaceControls(panelDisplay, pettyCash);
        }

        private void btnGenerateBarcode_Click(object sender, EventArgs e)
        {
            BarcodeGen barcodeGen = new BarcodeGen();
            barcodeGen.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.TopMost = true;
            settings.Show();

        }

        private void btnCreditPayment_Click(object sender, EventArgs e)
        {
            Credit_Payment creditPayment = new Credit_Payment(cashier) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formUtilities.replaceControls(panelDisplay, creditPayment);
        }


        private void bigAssTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (isAdmin)
            {
                if (e.KeyCode == Keys.F1)
                {
                    btnDashboard.PerformClick();
                }
                else if (e.KeyCode == Keys.F3)
                {
                    btnConsignments.PerformClick();
                }

                else if (e.KeyCode == Keys.F5)
                {
                    btnStaff.PerformClick();
                }
                else if (e.KeyCode == Keys.F6)
                {
                    btnInventory.PerformClick();
                }
                else if (e.KeyCode == Keys.F12)
                {
                    btnLogout.PerformClick();
                }
                else
                {

                }
            }
            else
            {
                if (e.KeyCode == Keys.F1)
                {
                    btnDashboard.PerformClick();
                }
                else if (e.KeyCode == Keys.F2)
                {
                    btnTransaction.PerformClick();
                }
                else if (e.KeyCode == Keys.F3)
                {
                    btnConsignments.PerformClick();
                }
                else if (e.KeyCode == Keys.F4)
                {
                    btnCredits.PerformClick();
                }
                else if (e.KeyCode == Keys.F7)
                {
                    btnPettyCash.PerformClick();
                }
                else if (e.KeyCode == Keys.F12)
                {
                    btnLogout.PerformClick();
                }
                else
                {

                }
            }

           
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnClose.PerformClick();
        }

        private void btnPriceArchive_Click(object sender, EventArgs e)
        {
            Price_Archive price = new Price_Archive();
            price.Show();
        }
    }
}
