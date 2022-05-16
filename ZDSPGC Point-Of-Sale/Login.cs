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
    public partial class Login : Form
    {
        Database database = new Database();
        Main_Menu mainMenu;
        public bool isAdmin=false;
        InputUtilities inputUtilities;
        public Login()
        {
            inputUtilities = new InputUtilities();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            database.cashierLogin(tbUsername.Text, tbPassword.Text);
            isAdmin = database.isAdmin;
            if (database.isLoggedIn)
            {
                mainMenu = new Main_Menu(isAdmin,database.cashierName);
                mainMenu.Show();
                inputUtilities.clearTextboxes(this);
            }
            else
            {
                MessageBox.Show("Login Failed, Please Enter your Credentials Correctly", "Login Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
