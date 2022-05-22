using FinalProject.BusinessLogic;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.ChildForms;

namespace Test
{
    public partial class MainPage : Form
    {
        private readonly AgancyService _agancyService;

        public MainPage()
        {
            InitializeComponent();
            _agancyService = new AgancyService();
           // custiomizeDesign();
            
        }
        //private void custiomizeDesign()
        //{
            //panelCarSubManu.Visible = false;
            //panelMotorcycleSubManu.Visible = false;
           // panelShipSubManu.Visible = false;
         //   //..
       // }

        //private void hideSubManu()
        //{
        //    if(panelCarSubManu.Visible == true)
        //    {
        //        panelCarSubManu.Visible=false;
        //    }
        //    if(panelMotorcycleSubManu.Visible == true)
        //    {
        //        panelMotorcycleSubManu.Visible = false;
        //    }
        //    if(panelShipSubManu.Visible==true)
        //    {
        //        panelShipSubManu.Visible = false;
        //    }

        //}
        private void ShowSubManu(Panel subManu)
        {
            if(subManu.Visible == false)
            {
                //hideSubManu();
                subManu.Visible=true;
            }
            else
            {
                subManu.Visible = false;
            }
        }
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildFormpanel.Controls.Add(childForm);
            ChildFormpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //private void btnCar_Click(object sender, EventArgs e)
        //{
        //    ShowSubManu(panelCarSubManu);
        //}




        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage homepage = new MainPage();
            homepage.Show();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            var items = _agancyService
                            .GetByType<PrivateCar>()
                            .AsEnumerable<Vehicle>()
                            .ToList();

            OpenChildForm(new ProduactForm(items,"Car"));
        }

        private void btnShips_Click(object sender, EventArgs e)
        {
            var items = _agancyService
                          .GetByType<Boat>()
                          .AsEnumerable<Vehicle>()
                          .ToList();
            OpenChildForm(new ProduactForm(items , "Boat"));
        }

        private void btnMotorcycle_Click(object sender, EventArgs e)
        {
            var items = _agancyService
                          .GetByType<Motorcycle>()
                          .AsEnumerable<Vehicle>()
                          .ToList();

            OpenChildForm(new ProduactForm(items , "Motorcycle"));
        }

        private void btnAllVehicles_Click(object sender, EventArgs e)
        {
            var items = _agancyService
                          .GetByType<PrivateCar>()
                          .AsEnumerable<Vehicle>()
                          .ToList();
            OpenChildForm(new ProduactForm(items, "All Vehicles"));
        }
    }
}

