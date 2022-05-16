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
    public partial class Settings : Form
    {
        InputUtilities inputUtilities;
        Database database;
        String updateCustomerID, updateSupplierID, updateUnitID;
        public Settings()
        {
            database = new Database();
            inputUtilities = new InputUtilities();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to add this record?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (inputUtilities.completelyFilled(gbAddCustomer))
                {
                    try
                    {
                        database.addCustomer(tbCustomerName.Text,tbCustomerAddress.Text,tbCustomerContact.Text);
                        MessageBox.Show("Customer Information Successfully Added!");
                    }
                    catch (Exception ex)
                    {
                        if (ex is MySql.Data.MySqlClient.MySqlException)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    database.fillCustomersTable(dgvCustomers);
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields.");
                }
            }
            else
            {

            }
        }

        private void gbAddCustomer_Enter(object sender, EventArgs e)
        {

        }

        private void tabPageCustomer_Click(object sender, EventArgs e)
        {
            database.fillCustomersTable(dgvCustomers);
        }

        private void tabPageSupplier_Click(object sender, EventArgs e)
        {
            database.fillSuppliersTable(dgvSupplier);
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateCustomerID = database.getCustomerIDByName(dgvCustomers.SelectedCells[0].Value.ToString());
            tbUpdateCustomeContact.Text = dgvCustomers.SelectedCells[2].Value.ToString();
            tbUpdateCustomeContact.Enabled = true;
            tbUpdateCustomerName.Text = dgvCustomers.SelectedCells[0].Value.ToString();
            tbUpdateCustomerName.Enabled = true;
            tbUpdateCustomerAddress.Text = dgvCustomers.SelectedCells[1].Value.ToString();
            tbUpdateCustomerAddress.Enabled = true;
            btnUpdateCustomer.Enabled = true;
        }

        private void dgvSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateSupplierID = database.getSupplierIDByName(dgvSupplier.SelectedCells[0].Value.ToString());
            tbUpdateSupplierContact.Text = dgvSupplier.SelectedCells[2].Value.ToString();
            tbUpdateSupplierContact.Enabled = true;
            tbUpdateSupplierName.Text = dgvSupplier.SelectedCells[0].Value.ToString();
            tbUpdateSupplierName.Enabled = true;
            tbUpdateSupplierAddress.Text = dgvSupplier.SelectedCells[1].Value.ToString();
            tbUpdateSupplierAddress.Enabled = true;
            btnUpdateSupplierInformation.Enabled = true;
            btnDeleteSupplierInformation.Enabled = true;
        }

        private void dgvUnit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbUpdateUnit.Text = dgvUnit.SelectedCells[0].Value.ToString();
            updateUnitID = database.getUnitIDByName(dgvUnit.SelectedCells[0].Value.ToString());
            tbUpdateUnit.Enabled = true;
            btnUpdateUnit.Enabled = true;
            btnDeleteUnit.Enabled = true;
        }

        private void btnUpdateSupplierInformation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this record?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (inputUtilities.completelyFilled(gbUpdateSupplier))
                {
                    try
                    {
                        database.updateSupplier(tbUpdateSupplierName.Text, tbUpdateSupplierAddress.Text, tbUpdateSupplierContact.Text, updateSupplierID);
                        MessageBox.Show("Supplier Information Successfully Updated!");
                    }
                    catch (Exception ex)
                    {
                        if (ex is MySql.Data.MySqlClient.MySqlException)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    database.fillSuppliersTable(dgvSupplier);
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields.");
                }
            }
            else
            {

            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this record?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (inputUtilities.completelyFilled(gbUpdateCustomer))
                {
                    try
                    {
                        database.updateCustomer(tbUpdateCustomerName.Text, tbUpdateCustomerAddress.Text, tbUpdateCustomeContact.Text, updateCustomerID);
                        MessageBox.Show("Customer Information Successfully Updated!");
                    }
                    catch (Exception ex)
                    {
                        if (ex is MySql.Data.MySqlClient.MySqlException)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    database.fillCustomersTable(dgvCustomers);
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields.");
                }
            }
            else
            {

            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to add this record?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (inputUtilities.completelyFilled(gbAddSupplier))
                {
                    try
                    {
                        database.addSupplier(tbSupplierName.Text, tbSupplierAddress.Text, tbSupplierContact.Text);
                        MessageBox.Show("Supplier Information Successfully Added!");
                    }
                    catch (Exception ex)
                    {
                        if (ex is MySql.Data.MySqlClient.MySqlException)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    database.fillSuppliersTable(dgvSupplier);
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields.");
                }
            }
            else
            {

            }
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to add this record?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (inputUtilities.completelyFilled(gbAddUnit))
                {
                    try
                    {
                        database.addUnit(tbUnit.Text);
                        MessageBox.Show("Unit Successfully Added!");
                    }
                    catch (Exception ex)
                    {
                        if (ex is MySql.Data.MySqlClient.MySqlException)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    database.fillUnitsTable(dgvUnit);
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields.");
                }
            }
            else
            {

            }
        }

        private void btnUpdateUnit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to add this record?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (inputUtilities.completelyFilled(gbUpdateUnit))
                {
                    try
                    {
                        database.updateUnit(tbUpdateUnit.Text,updateUnitID);
                        MessageBox.Show("Unit Successfully Updated!");
                    }
                    catch (Exception ex)
                    {
                        if (ex is MySql.Data.MySqlClient.MySqlException)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    database.fillUnitsTable(dgvUnit);
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields.");
                }
            }
            else
            {

            }
        }

        private void btnDeleteUnit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (inputUtilities.completelyFilled(gbUpdateUnit))
                {
                    try
                    {
                        database.deleteUnit(updateUnitID);
                        MessageBox.Show(updateUnitID.ToString());
                        MessageBox.Show("Unit Successfully Deleted!");
                    }
                    catch (Exception ex)
                    {
                        if (ex is MySql.Data.MySqlClient.MySqlException)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    database.fillUnitsTable(dgvUnit);
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields.");
                }
            }
            else
            {

            }
        }

        private void btnDeleteSupplierInformation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (inputUtilities.completelyFilled(gbUpdateSupplier))
                {
                    try
                    {

                        database.deleteSupplier(updateSupplierID);
                        MessageBox.Show("Supplier Information Successfully Deleted!");
                    }
                    catch (Exception ex)
                    {
                        if (ex is MySql.Data.MySqlClient.MySqlException)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    database.fillSuppliersTable(dgvSupplier);
                    inputUtilities.clearTextboxes(gbUpdateSupplier);
                    inputUtilities.disableUpdateControls(gbUpdateSupplier);
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields.");
                }
            }
            else
            {

            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
          
          
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            database.fillCustomersTable(dgvCustomers);
            database.fillSuppliersTable(dgvSupplier);
            database.fillUnitsTable(dgvUnit);

        }

        private void tbUpdateSupplierName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tpUnit_Click(object sender, EventArgs e)
        {
            database.fillUnitsTable(dgvUnit);
        }
    }
}
