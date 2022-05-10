using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Forms
{
    public partial class Jetski : Form
    {
        public Jetski()
        {
            InitializeComponent();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage page = new HomePage();
            page.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ships ships = new Ships();
            ships.Show();
        }
    }
}
