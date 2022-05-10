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
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void btnATV_Click(object sender, EventArgs e)
        {
            this.Hide();
            GasCar gasCar = new GasCar();   
            gasCar.Show();
        }

        private void btnBikes_Click(object sender, EventArgs e)
        {
            this.Hide();
            ElectricCar electricCar = new ElectricCar();
            electricCar.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage page = new HomePage(); 
            page.Show();
        }
    }
}
