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
    public partial class Staff : Form
    {
        Database database;
        InputUtilities inputUtilities;
        public String updateID,updateAdminID;
        public Staff()
        {
            database = new Database();
            inputUtilities = new InputUtilities();           
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void tabPageAdmin_Click(object sender, EventArgs e)
        {
            database.fillAdminTable(dgvAdmins);
        }

        private void tabPageCashier_Click(object sender, EventArgs e)
        {
            database.fillCashierTable(dgvCashier);
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            database.fillAdminTable(dgvAdmins);
            database.fillCashierTable(dgvCashier);
        }

        private void dgvCashier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateID = dgvCashier.SelectedCells[0].Value.ToString();
            tbUpdateName.Text = dgvCashier.SelectedCells[1].Value.ToString();
            tbUpdateName.Enabled = true;
            tbUpdateUsername.Text = dgvCashier.SelectedCells[2].Value.ToString();
            tbUpdateUsername.Enabled = true;
            tbUpdatePassword.Text = dgvCashier.SelectedCells[3].Value.ToString();
            tbUpdatePassword.Enabled = true;
            btnUpdate.Enabled = true;
            btnDeleteCashier.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (inputUtilities.completelyFilled(gbUpdateCashier))
                    {
                        database.updateCashier(tbUpdateName.Text, tbUpdateUsername.Text, tbUpdatePassword.Text, updateID);
                        MessageBox.Show("Cashier Record Successfully Updated!");
                        inputUtilities.disableUpdateControls(gbUpdateCashier);
                        database.fillCashierTable(dgvCashier);
                    }
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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to add this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (inputUtilities.completelyFilled(gbAddCashier))
                    {
                        database.addCashier(tbName.Text, tbUsername.Text, tbPassword.Text);
                        MessageBox.Show("Cashier Record Successfully Added!");
                        database.fillCashierTable(dgvCashier);
                    }
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

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to add this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (inputUtilities.completelyFilled(gbAddAdmin))
                    {
                        database.addAdmin(tbAdminName.Text, tbAdminUsername.Text, tbAdminPassword.Text);
                        MessageBox.Show("Admin Record Successfully Added!");
                        database.fillAdminTable(dgvAdmins);
                    }
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

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (inputUtilities.completelyFilled(gbUpdateAdmin))
                    {
                        database.updateAdmin(tbUpdateAdminName.Text, tbUpdateAdminUsername.Text, tbUpdateAdminPassword.Text, updateAdminID);
                        MessageBox.Show("Admin Record Successfully Updated!");
                        inputUtilities.disableUpdateControls(gbUpdateAdmin);
                        database.fillAdminTable(dgvAdmins);
                    }
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

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (inputUtilities.completelyFilled(gbUpdateAdmin))
                    {
                        database.deleteAdmin(updateAdminID);
                        MessageBox.Show("Admin Record Successfully Deleted!");
                        inputUtilities.disableUpdateControls(gbUpdateAdmin);
                    }
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

        private void dgvAdmins_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateAdminID = dgvAdmins.SelectedCells[0].Value.ToString();
            tbUpdateAdminName.Text = dgvAdmins.SelectedCells[1].Value.ToString();
            tbUpdateAdminName.Enabled = true;
            tbUpdateAdminUsername.Text = dgvAdmins.SelectedCells[2].Value.ToString();
            tbUpdateAdminUsername.Enabled = true;
            tbUpdateAdminPassword.Text = dgvAdmins.SelectedCells[3].Value.ToString();
            tbUpdateAdminPassword.Enabled = true;
            btnUpdateAdmin.Enabled = true;
           btnDeleteAdmin.Enabled = true;
        }

        private void btnDeleteCashier_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (inputUtilities.completelyFilled(gbUpdateCashier))
                    {
                        database.deleteCashier(updateID);
                        MessageBox.Show("Cashier Record Successfully Deleted!");
                        inputUtilities.disableUpdateControls(gbUpdateCashier);
                        database.fillCashierTable(dgvCashier);
                    }
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
    }
}
