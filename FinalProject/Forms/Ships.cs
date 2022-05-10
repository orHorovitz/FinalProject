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
    public partial class Ships : Form
    {
        public Ships()
        {
            InitializeComponent();
        }



        private void btnHomePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage page = new HomePage();
            page.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYacht_Click(object sender, EventArgs e)
        {
            this.Hide();
            Yacht yacht = new Yacht();
            yacht.Show();
        }

        private void btnJetski_Click(object sender, EventArgs e)
        {
            this.Hide();
            Jetski jetski = new Jetski();
            jetski.Show();
        }
    }
}
