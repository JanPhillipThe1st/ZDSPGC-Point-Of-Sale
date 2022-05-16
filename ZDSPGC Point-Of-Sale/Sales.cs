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
    public partial class Sales : Form
    {
        public bool isAdmin;
        Database database;
        public String cashier;
        Printer printer;
        public Sales(bool isAdmin,String cashier)
        {
            this.cashier = cashier;
            this.isAdmin = isAdmin;
            database = new Database();
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            String newString = String.Empty;
            
            switch (cbReport.SelectedIndex)
            {
                case 0 :
                    newString = "Inventory Report of ZDSPC Canteen";
                    lblReportLabel.Text = newString;
                    database.fillInventoryTable(dgvItems);
                    dtpFrom.Enabled = false;
                    dtpTo.Enabled = false;
                    getTotal();
                    break;
                case 1:
                    newString = "Sales Report of ZDSPC Canteen";
                    dtpFrom.Enabled = true;
                    dtpTo.Enabled = true;
                    lblReportLabel.Text = newString;
                    if (isAdmin)
                    {
                        database.fillSalesTableAdminByDate(dgvItems, dtpFrom.Value, dtpTo.Value);
                    }
                    else
                    {
                        database.fillSalesTableCashierByDate(dgvItems, dtpFrom.Value, dtpTo.Value, cashier);
                    }
                    getTotal();
                    break;
                    
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            String newString = String.Empty;
            
            switch (cbReport.SelectedIndex)
            {
                case 0:
                    newString = "Inventory Report of ZDSPC Canteen";
                    lblReportLabel.Text = newString;
                    database.fillInventoryTable(dgvItems);
                    getTotal();
                    break;
                case 1:
                    newString = "Sales Report of ZDSPC Canteen";
                    lblReportLabel.Text = newString;
                    if (isAdmin)
                    {
                        database.fillSalesTableAdminByDate(dgvItems, dtpFrom.Value, dtpTo.Value);
                    }
                    else
                    {
                        database.fillSalesTableCashierByDate(dgvItems, dtpFrom.Value, dtpTo.Value, cashier);
                    }
                    getTotal();
                    break;
                    
            }
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            String newString = String.Empty;
            
            switch (cbReport.SelectedIndex)
            {
                case 0:
                    newString = "Inventory Report of ZDSPC Canteen";
                    lblReportLabel.Text = newString;
                    database.fillInventoryTable(dgvItems);
                    getTotal();
                    break;
                case 1:
                    newString = "Sales Report of ZDSPC Canteen";
                    lblReportLabel.Text = newString;
                    if (isAdmin)
                    {
                        database.fillSalesTableAdminByDate(dgvItems, dtpFrom.Value, dtpTo.Value);
                    }
                    else
                    {
                        database.fillSalesTableCashierByDate(dgvItems, dtpFrom.Value, dtpTo.Value, cashier);
                    }
                    getTotal();
                    break;
                    
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            printer = new Printer(cbReport.Text,dgvItems);
            printer.printReport();
            
        }
        private void getTotal() {
            String label = "";
            Double totalSold = 0;
            int totalSoldQuantity = 0;
            if (dgvItems.Rows.Count <= 0 )
            {

            }
            else
            {
                if (cbReport.SelectedIndex == 0)
                {
                    label = "Total Sold:";
                    foreach (DataGridViewRow item in dgvItems.Rows)
                    {
                        totalSoldQuantity += Convert.ToInt32(item.Cells[7].Value.ToString());
                    }
                    lblTotals.Text = label + totalSoldQuantity.ToString(); ;

                }
                else if (cbReport.SelectedIndex == 1)
                {
                    label = "Total Sales:";
                    foreach (DataGridViewRow item in dgvItems.Rows)
                    {
                        totalSold += Convert.ToDouble(item.Cells[5].Value.ToString());
                    }
                    lblTotals.Text = label + totalSold.ToString();
                }
            }
            
        }
    }
}
