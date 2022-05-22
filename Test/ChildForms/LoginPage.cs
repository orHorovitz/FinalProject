using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.ChildForms
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtboxUsername.Text == "Admin" && txtboxPassword.Text == "1234")
            {
                new MainPage().Show();
                this.Hide();
            }
            else
            {
                if(txtboxPassword.Text == null)
                {
                    MessageBox.Show("Please enter Password");
                }
                MessageBox.Show("The user name or password are incorrect");
                txtboxUsername.Clear();
                txtboxPassword.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxUsername.Clear();
            txtboxPassword.Clear();
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnMinimizeLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
