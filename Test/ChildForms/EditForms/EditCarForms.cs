using FinalProject.BusinessLogic;
using FinalProject.Models;
using FinalProject.Models.PrivateCarEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.ChildForms.EditForms
{
    public partial class EditCarForms : Form
    {
        private readonly PrivateCar _privateCar;
        private readonly AgancyService _service;
        public EditCarForms(PrivateCar _privateCar)
        {
            InitializeComponent();
            this._privateCar = _privateCar;
            _service = new AgancyService();
            GenerateFields(_privateCar);
            btnEditCar.Click += btnEditCar_Click;
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            if (_privateCar is ElectricCar b)
            {
                _service.UpdateItem(
                    new ElectricCar(double.Parse(txtBoxPriceEditC.Text),
                             double.Parse(txtBoxWeightEditC.Text),
                             int.Parse(txtBoxPassAmountEditC.Text),
                             DateTime.Parse(txtboxManfactorEditC.Text),
                             /*double.Parse(txtBoxPricePerEditBike.Text)*/ 34,
                             comboBoxIsRentEditC.SelectedIndex == 0 ? true : false,
                             int.Parse(txtBoxMileageEditC.Text),
                             double.Parse(txtboxEditDependedC.Text)
                             ), _privateCar.Id);
            }
            else if (_privateCar is GasCar a)
            {
                _service.UpdateItem(
                   new GasCar(double.Parse(txtBoxPriceEditC.Text),
                            double.Parse(txtBoxWeightEditC.Text),
                            int.Parse(txtBoxPassAmountEditC.Text),
                            DateTime.Parse(txtboxManfactorEditC.Text),
                            double.Parse(txtBoxPricePerEditC.Text) ,
                            comboBoxIsRentEditC.SelectedIndex == 0 ? true : false,
                            int.Parse(txtBoxMileageEditC.Text),
                            double.Parse(txtboxEditDependedC.Text))
                           , _privateCar.Id);
            }
            this.Close();
        }
        private void GenerateFields(PrivateCar privateCar)
        {
            this.txtBoxPriceEditC.Text = privateCar.PricePerDay.ToString();
            this.txtBoxWeightEditC.Text = privateCar.Weight.ToString();
            this.txtBoxPassAmountEditC.Text = privateCar.PassangerAmount.ToString();
            //this.txtBoxImageEditBike.Text = motorcycle.ImageUri.ToString();
            this.txtboxManfactorEditC.Text = privateCar.ManufactorDate.ToString();
            this.comboBoxIsRentEditC.SelectedIndex = privateCar.IsRentedNow ? 0 : 1;
            this.txtBoxMileageEditC.Text = privateCar.Mileage.ToString();


        }
    }
}
