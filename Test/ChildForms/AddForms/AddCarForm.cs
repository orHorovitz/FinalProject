using FinalProject.Models;
using FinalProject.Models.Enums;
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
    public partial class AddCarForm : Form
    {
        private string[] _categories;
        private readonly FinalProject.BusinessLogic.AgancyService _agancy;
        public string TypeName { get; private set; }
        private IVehicleView view;
        public AddCarForm(FinalProject.BusinessLogic.AgancyService _agancy , IVehicleView view)
        {
            InitializeComponent();
            makeItFalse();
            this.view = view;
            //lblIsRendCar.Visible = false;
            //lblManufactorCar.Visible = false;
            //lblMileageCar.Visible = false;
            //lblPassAmountCar.Visible = false;
            //lblPriceCar.Visible = false;
            //lblWeightCar.Visible = false;
            //lblPricePerDayCar.Visible = false;
            //lblImage.Visible = false;
            
            this._agancy = _agancy;
            //_categories = Enum.GetNames(typeof(Cars));
            //cmbTypes.Items.AddRange(_categories);
            //cmbTypes.SelectedIndexChanged += CmbTypes_SelectedIndexChanged;
        }

        private void CmbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox cmb)
            {
                TypeName = cmb.SelectedItem.ToString();
                RenderForm();
            }
        }

        private void RenderForm()
        {
            //gb.Controls.Clear();
            var lblPrice = new Label();
            lblPrice.Text = "Price";
            var tbxPrice = new Label();

            var lblweight = new Label();
            lblweight.Text = "Weight";
            var tbxweight = new TextBox();

            var lbMilage = new Label();
            lbMilage.Text = "Milage";
            var tbxMilage = new TextBox();

            //gb.Controls.Add(lblPrice);
            //gb.Controls.Add(tbxPrice);
            //gb.Controls.Add(lblweight);
            //gb.Controls.Add(tbxweight);
            //gb.Controls.Add(lbMilage);
            //gb.Controls.Add(tbxMilage);
            

            if (TypeName == "GasCar")
            {
                var lblFuel= new Label();
                lblFuel.Text = "Fuel";
                var tbxFuel = new TextBox();

                //gb.Controls.Add(lblFuel);
                //gb.Controls.Add(tbxFuel);
            }
            else
            {
                var lblPower = new Label();
                lblPower.Text = "Power";
                var tbxPower = new TextBox();

                //gb.Controls.Add(lblPower);
                //gb.Controls.Add(tbxPower);
            }
        }

        private void btnRefrash_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 1)
            {
                lblDepended.Text = "Fuel Storage :";
                lbl__DependedCar.Location = new System.Drawing.Point(608, 311);
                txtBoxDependedCar.Location = new System.Drawing.Point(608, 311);
                lblPleaseChooseType.Visible = false;
                makeItTrue();
            }
            else if(comboBoxType.SelectedIndex == 2)
            {
                lblDepended.Text = "Power :";
                lbl__DependedCar.Location = new System.Drawing.Point(545, 311);
                txtBoxDependedCar.Location = new System.Drawing.Point(545, 311);
                lblPleaseChooseType.Visible = false;
                makeItTrue();
            }
        }

        private void AddCarForm_Load(object sender, EventArgs e)
        {

        }

       private void makeItFalse()
        {
            lblIsRendCar.Visible = false;
            lblManufactorCar.Visible = false;
            lblMileageCar.Visible = false;
            lblPassAmountCar.Visible = false;
            lblPriceCar.Visible = false;
            lblWeightCar.Visible = false;
            lblPricePerDayCar.Visible = false;
            lblImage.Visible = false;
            lblDepended.Visible = false;
            lbl__DependedCar.Visible = false;
            lbl__ImageCar.Visible = false;
            lbl__ManfactorCar.Visible = false;
            lbl__MileageCar.Visible=false;
            lbl__PriceCar.Visible = false;
            lbl__PricePerDayCar.Visible = false;
            comboBoxRentCar.Visible = false;
            lbl__WeightCar.Visible = false;
            lbl__PassCar.Visible = false;

        }

        private void makeItTrue()
        {
            lblIsRendCar.Visible = true;
            lblManufactorCar.Visible = true;
            lblMileageCar.Visible = true;
            lblPassAmountCar.Visible = true;
            lblPriceCar.Visible = true;
            lblWeightCar.Visible = true;
            lblPricePerDayCar.Visible = true;
            lblImage.Visible = true;
            lblDepended.Visible = true;
            lbl__DependedCar.Visible = true;
            lbl__ImageCar.Visible = true;
            lbl__ManfactorCar.Visible = true;
            lbl__MileageCar.Visible = true;
            lbl__PriceCar.Visible = true;
            lbl__PricePerDayCar.Visible = true;
            comboBoxRentCar.Visible = true;
            lbl__WeightCar.Visible = true;
            lbl__PassCar.Visible = true;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            FinalProject.Models.Vehicle newCar = null;
            double Price = double.Parse(txtBoxPriceCar.Text);
            double Weight = double.Parse(txtBoxWeightCar.Text);
            int PassangerAmount = int.Parse(txtBoxPassAmountCar.Text);
            DateTime dateTime = DateTime.Parse(txtBoxManufactorCar.Text);
            double PricePerDay = double.Parse(txtBoxPricePerCar.Text);
            bool isRend;
            if(comboBoxRentCar.SelectedIndex == 0)
            {
                isRend = true;
            }
            else
            {
                isRend = false;
            }
            int Mileage = int.Parse(txtBoxMileageCar.Text);
            string Url = txtBoxImageCar.Text;
            if (comboBoxType.SelectedIndex == 1)
            {
                double FuelStorage = double.Parse(txtBoxDependedCar.Text);
                newCar = new FinalProject.Models.PrivateCarEntities.GasCar(Price, Weight, PassangerAmount, dateTime, PricePerDay, isRend, Mileage, FuelStorage, Url);
            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                double Power = double.Parse(txtBoxDependedCar.Text);
                newCar = new FinalProject.Models.PrivateCarEntities.ElectricCar(Price, Weight, PassangerAmount, dateTime, PricePerDay, isRend, Mileage, Power, Url);
            }

            //return newCar;
            //Adding Item
            
            if(_agancy.Add(newCar))
            {
                view.AddVehicle(newCar);
            }

            this.Close();
        }
    }
}
