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
    public partial class Inventory : Form
    {
        Database database;
        public int remainingQuantity;
        InputUtilities inputUtilities;
        String updateName, updateID;
        Double oldPrice = 0;
        public Inventory()
        {
            inputUtilities = new InputUtilities();
            database = new Database();
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            database.fillInventoryTable(dgvItems);
            cbUnit.Items.AddRange(database.getUnitsAsDictionary().Keys.ToArray<String>());
            cbUpdateUnit.Items.AddRange(database.getUnitsAsDictionary().Keys.ToArray<String>());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to add '" + tbItemDescription.Text + "'?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (inputUtilities.completelyFilled(gbAddItem))
                {
                    try
                    {
                        Double unitPrice, originalPrice;
                        unitPrice = Convert.ToDouble(tbUnitPrice.Text);
                        originalPrice = Convert.ToDouble(tbOriginalPrice.Text);
                        int quantity = Convert.ToInt32(tbQuantity.Text);
                        database.addItem(tbBarcode.Text,tbItemDescription.Text, cbUnit.Text, originalPrice, unitPrice, quantity, DateTime.Now.Date);
                        database.addPriceArchive(tbItemDescription.Text,unitPrice,unitPrice,DateTime.Now);
                        MessageBox.Show("Item Successfully Updated!");
                    }
                    catch (Exception ex)
                    {
                        if (ex is MySql.Data.MySqlClient.MySqlException)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    database.fillInventoryTable(dgvItems);
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

        private void tbOriginalPrice_TextChanged(object sender, EventArgs e)
        {
            if (!inputUtilities.isDouble(tbOriginalPrice.Text))
            {
                tbOriginalPrice.Clear();
            }
        }

        private void tbUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (!inputUtilities.isDouble(tbUnitPrice.Text))
            {
                tbUnitPrice.Clear();
            }
        }

        private void tbUpdateOriginalPrice_TextChanged(object sender, EventArgs e)
        {
            if (!inputUtilities.isDouble(tbUpdateOriginalPrice.Text))
            {
                tbUpdateOriginalPrice.Clear();
            }
        }

        private void tbUpdateUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (!inputUtilities.isDouble(tbUpdateUnitPrice.Text))
            {
                tbUpdateUnitPrice.Clear();
            }
        }

        private void tbUpdateQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!inputUtilities.isInteger(tbUpdateQuantity.Text))
            {
                tbUpdateQuantity.Clear();
            }
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!inputUtilities.isInteger(tbQuantity.Text))
            {
                tbQuantity.Clear();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update '" +updateName + "' ?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (inputUtilities.completelyFilled(gbUpdateItem))
                {
                    try
                    {
                        Double unitPrice, originalPrice;
                        unitPrice = Convert.ToDouble(tbUpdateUnitPrice.Text);
                        originalPrice = Convert.ToDouble(tbUpdateOriginalPrice.Text);
                        int quantity = Convert.ToInt32(tbUpdateQuantity.Text);
                        int addedQuantity = Convert.ToInt32(tbUpdateRemainingQuantity.Text);
                        database.updateItem(tbUpdateBarcode.Text, tbUpdateItemDescription.Text, cbUpdateUnit.Text, originalPrice, unitPrice, quantity,remainingQuantity,addedQuantity, updateID);
                        database.addPriceArchive(tbUpdateItemDescription.Text,oldPrice,unitPrice,DateTime.Now);
                        MessageBox.Show("Item Successfully Updated!");
                    }
                    catch (Exception ex)
                    {
                        if (ex is MySql.Data.MySqlClient.MySqlException)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        throw;
                    }

                    database.fillInventoryTable(dgvItems);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete '" + updateName + "'?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (inputUtilities.completelyFilled(gbUpdateItem))
                {
                    try
                    {
                        Double unitPrice, originalPrice;
                        unitPrice = Convert.ToDouble(tbUpdateUnitPrice.Text);
                        originalPrice = Convert.ToDouble(tbUpdateOriginalPrice.Text);
                        int quantity = Convert.ToInt32(tbUpdateQuantity.Text);
                        database.deleteItem(updateID);
                        MessageBox.Show("Item Successfully Deleted!");
                    }
                    catch (Exception ex)
                    {
                        if (ex is MySql.Data.MySqlClient.MySqlException)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    database.fillInventoryTable(dgvItems);
                }
                else
                {
                    MessageBox.Show("Please Select an Item to DELETE!");
                }
            }
            else
            {

            }
        }

        private void gbUpdateItem_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddToConsignment_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to add '" + tbItemDescription.Text + "' to Consigments?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (inputUtilities.completelyFilled(gbAddItem))
                {
                    try
                    {
                        Double unitPrice, originalPrice;
                        unitPrice = Convert.ToDouble(tbUnitPrice.Text);
                        originalPrice = Convert.ToDouble(tbOriginalPrice.Text);
                        int quantity = Convert.ToInt32(tbQuantity.Text);
                        Add_Consignment add_Consignment = new Add_Consignment(tbBarcode.Text,tbItemDescription.Text,cbUnit.Text,originalPrice,unitPrice,quantity);
                        add_Consignment.Show();
                        database.addPriceArchive(tbItemDescription.Text, unitPrice, unitPrice, DateTime.Now);
                        
                    }
                    catch (Exception ex)
                    {
                        if (ex is MySql.Data.MySqlClient.MySqlException)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    database.fillInventoryTable(dgvItems);
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

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            tbUpdateItemDescription.Text = dgvItems.SelectedCells[0].Value.ToString();
            cbUpdateUnit.Text = dgvItems.SelectedCells[2].Value.ToString();
            tbUpdateOriginalPrice.Text = dgvItems.SelectedCells[2].Value.ToString();
            tbUpdateUnitPrice.Text = dgvItems.SelectedCells[3].Value.ToString();
            oldPrice = Convert.ToDouble(dgvItems.SelectedCells[3].Value.ToString());
            tbUpdateQuantity.Text = dgvItems.SelectedCells[5].Value.ToString();
            tbUpdateRemainingQuantity.Text = dgvItems.SelectedCells[6].Value.ToString();
            remainingQuantity = Convert.ToInt32(dgvItems.SelectedCells[6].Value.ToString());
            updateName = dgvItems.SelectedCells[0].Value.ToString();
            tbUpdateBarcode.Text = database.getItemsAsDictionary()[updateName];
            updateID = database.getItemsAsDictionary()[updateName];

            tbUpdateBarcode.Enabled = true;
            tbUpdateRemainingQuantity.Enabled = true;
            tbUpdateItemDescription.Enabled = true;
            cbUpdateUnit.Enabled = true;
            tbUpdateOriginalPrice.Enabled = true;
            tbUpdateUnitPrice.Enabled = true;
            tbUpdateQuantity.Enabled = true;
            btnConfirm.Enabled = true;
            btnDelete.Enabled = true;
        }
    }
}
