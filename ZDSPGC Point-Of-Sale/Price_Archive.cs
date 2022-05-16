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
    public partial class Price_Archive : Form
    {
        Database database;
        public Price_Archive()
        {
            database = new Database();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Price_Archive_Load(object sender, EventArgs e)
        {
            database.fillPriceArchive(dgvPriceArchive);
            AutoCompleteStringCollection items = new AutoCompleteStringCollection();
            tbSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            items.AddRange(database.getProductsAsDictionary().Keys.ToArray<String>());
            tbSearch.AutoCompleteCustomSource = items;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            database.fillPriceArchive(dgvPriceArchive,tbSearch.Text);
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }
    }
}
