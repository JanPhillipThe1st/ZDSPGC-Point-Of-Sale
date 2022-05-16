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
    public partial class Dashboard : Form
    {
        Database database;
        public bool isAdmin;
        public String cashier;
        public Dashboard(bool isAdmin,String cashier)
        {
            this.cashier = cashier;
            this.isAdmin = isAdmin;
            database = new Database();
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            database.fillLowStockProductsTable(dgvLowStockProducts);
            if (isAdmin)
            {
                database.fillDailySalesTable(dgvDailySales);
            }
            else
            {
                database.fillDailySalesTableCashier(dgvDailySales,cashier);
            }
            getTotal();
        }

        private void btnPrintSalesReport_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales(isAdmin,cashier);
            sales.Show();
        }
        private void getTotal() {
            String total = "Total Sales: ";

            Double totalSales = 0;
            foreach (DataGridViewRow row in dgvDailySales.Rows)
            {
                totalSales += Convert.ToDouble(row.Cells[4].Value);
            }
            InputUtilities inputUtilities = new InputUtilities();
            if (inputUtilities.isIntegerNoMessage(totalSales.ToString()))
            {
                lblTotalSales.Text = (total + String.Format("{0:0.00}", totalSales.ToString())+".00");
            }
            else
            {
                lblTotalSales.Text = (total + String.Format("{0:0.00}", totalSales.ToString()));
            }

        }
    }
}
