using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            custiomizeDesign();
            
        }
        private void custiomizeDesign()
        {
            panelCarSubManu.Visible = false;
            panelMotorcycleSubManu.Visible = false;
            panelShipSubManu.Visible = false;
            //..
        }

        private void hideSubManu()
        {
            if(panelCarSubManu.Visible == true)
            {
                panelCarSubManu.Visible=false;
            }
            if(panelMotorcycleSubManu.Visible == true)
            {
                panelMotorcycleSubManu.Visible = false;
            }
            if(panelShipSubManu.Visible==true)
            {
                panelShipSubManu.Visible = false;
            }

        }
        private void ShowSubManu(Panel subManu)
        {
            if(subManu.Visible == false)
            {
                hideSubManu();
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

        private void btnCar_Click(object sender, EventArgs e)
        {
            ShowSubManu(panelCarSubManu);
        }

        private void btnGasCar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForms.ElectricCarForm());
            //..
           // hideSubManu();
        }

        private void btnElectricCar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForms.GasCarForm());
            //...
           // hideSubManu();
        }

        private void btnShips_Click(object sender, EventArgs e)
        {
            ShowSubManu(panelShipSubManu);
        }

        private void btnJetski_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForms.JeySkiForm());
            //...
            //hideSubManu();
        }

        private void btnYacht_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForms.YachtForm());
            //...
            //hideSubManu();
        }

        private void btnMotorcycle_Click(object sender, EventArgs e)
        {

            ShowSubManu(panelMotorcycleSubManu);
        }

        private void btnAtv_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForms.AtvForm());
            //..
            //hideSubManu();
        }

        private void btnBike_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForms.BikeForm());
            //...
            //hideSubManu();
        }

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
    }
}

