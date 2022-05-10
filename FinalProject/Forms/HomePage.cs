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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTitleTxt_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage page = new HomePage();
            page.Show();
        }

        private void btnAllvehicles_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AllVehicles allVehicles = new AllVehicles();
            allVehicles.Show();
        }

        private void btnMotorcycle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.Show();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cars cars = new Cars();
            cars.Show();
        }

        private void btnShips_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ships ships = new Ships(); 
            ships.Show();
        }
    }
}
