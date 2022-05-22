using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.ChildForms.AddForms
{
    public partial class AddBikeForm : Form
    {
        private readonly FinalProject.BusinessLogic.AgancyService _agancy;
        public string TypeName { get; private set; }
        private IVehicleView view;

        public AddBikeForm(FinalProject.BusinessLogic.AgancyService _agancy, IVehicleView view)
        {
            InitializeComponent();
            this.view = view;
            this._agancy = _agancy;
            makeItFalse();
        }

        private void btnRefrash_Click(object sender, EventArgs e)
        {
            if(comboBoxTypeMotor.SelectedIndex == 1)
            {
                makeItTrue();
                lblPleaseChooseType.Visible = false;
                lblDependedMotor.Text = "IsDirt :";
                ComboBoxIsRendMotor.Visible = true;

            }
            else if(comboBoxTypeMotor.SelectedIndex == 2)
            {
                makeItTrue();
                lblPleaseChooseType.Visible = false;
                lblDependedMotor.Text = "IsSport :";
                ComboBoxIsRendMotor.Visible = true;
            }
        }

        private void makeItFalse()
        {
            lblManufactorMotor.Visible = false;
            lblMaxSpeedMotor.Visible = false;
            lblPassAmountMotor.Visible = false;
            lblPriceMotor.Visible = false;
            lblTypeDepended.Visible = false;
            lblPricePerDayMotor.Visible = false;
            lblDependedMotor.Visible = false;
            lblIsRendMotor.Visible = false;
            lblWeightMotor.Visible = false;
            lblImageMotor.Visible = false;
            ComboBoxDependedBike.Visible = false;
            //lbl__ImageMotor.Visible = false;
            lbl__ManfactorMotor.Visible = false;
            lbl__MileageMotor.Visible = false;
            lbl__PassMotor.Visible = false;
            lbl__PriceMotor.Visible = false;
            lbl__PricePerDayMotor.Visible =false;
            ComboBoxIsRendMotor.Visible = false;
            lbl__WeightMotor.Visible = false;
        }
        private void makeItTrue()
        {
            lblManufactorMotor.Visible = true;
            lblMaxSpeedMotor.Visible = true;
            lblPassAmountMotor.Visible = true;
            lblPriceMotor.Visible = true;
            lblTypeDepended.Visible = true;
            lblPricePerDayMotor.Visible = true;
            lblDependedMotor.Visible = true;
            lblIsRendMotor.Visible = true;
            lblWeightMotor.Visible = true;
            lblImageMotor.Visible = true;
            ComboBoxDependedBike.Visible=true;
            //lbl__ImageMotor.Visible = true;
            lbl__ManfactorMotor.Visible = true;
            lbl__MileageMotor.Visible = true;
            lbl__PassMotor.Visible = true;
            lbl__PriceMotor.Visible = true;
            lbl__PricePerDayMotor.Visible = true;
            ComboBoxIsRendMotor.Visible = false;
            lbl__WeightMotor.Visible = true;
        }

        private void btnAddBoat_Click(object sender, EventArgs e)
        {
            FinalProject.Models.Vehicle NewMotorcycle = null;
            double Price = double.Parse(txtBoxPriceMotor.Text);
            double Weight = double.Parse(txtBoxWeightMotor.Text);
            int PassangerAmount = int.Parse(txtBoxPassAmountMotor.Text);
            DateTime dateTime = DateTime.Parse(txtBoxManufactorMotor.Text);
            double PricePerDay = double.Parse(txtBoxPricePerMotor.Text);
            bool isRend;
            bool isDirt;
            bool isSport;
            if (ComboBoxIsRendMotor.SelectedIndex == 0)
            {
                isRend = true;
            }
            else
            {
                isRend = false;
            }
            int MaxSpeed = int.Parse(txtBoxMaxSpeedMotor.Text);
            string Url = txtBoxImageMotor.Text;
            if (comboBoxTypeMotor.SelectedIndex == 1)
            {
                if(ComboBoxDependedBike.SelectedIndex == 0)
                {
                    isDirt = true;
                }
                else
                {
                    isDirt= false;
                }
                NewMotorcycle = new FinalProject.Models.BikeEntities.ATV(Price, Weight, PassangerAmount, dateTime, PricePerDay, isRend, MaxSpeed, isDirt, Url);
            }
            else if (comboBoxTypeMotor.SelectedIndex == 2)
            {
                if (ComboBoxDependedBike.SelectedIndex == 0)
                {
                    isSport = true;
                }
                else
                {
                    isSport = false;
                }

                NewMotorcycle = new FinalProject.Models.BikeEntities.Bike(Price, Weight, PassangerAmount, dateTime, PricePerDay, isRend, MaxSpeed, isSport, Url);
            }

            //return newCar;
            //Adding Item

            if (_agancy.Add(NewMotorcycle))
            {
                view.AddVehicle(NewMotorcycle);
            }

            this.Close();
        }

        private void btnUploadBike_Click(object sender, EventArgs e)
        {
            String imageLocation;
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                //dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)| All Files(*.*)|*.*";

                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                }
            }catch (Exception)
            {
                MessageBox.Show("An Error Occured","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
