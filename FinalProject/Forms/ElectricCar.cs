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
    public partial class ElectricCar : Form
    {
        public ElectricCar()
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
    }
}
