using FinalProject.BusinessLogic;
using FinalProject.Models;
using FinalProject.Models.BikeEntities;
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
    public partial class EditBikeForm : Form
    {
        private readonly Motorcycle _motorcycle;
        private readonly AgancyService _service;

        public EditBikeForm(Motorcycle motorcycle)
        {
            InitializeComponent();
            this._motorcycle = motorcycle;
            _service = new AgancyService();
            GenerateFields(_motorcycle);
            btnEditBike.Click += BtnEditBike_Click;
        }

        private void BtnEditBike_Click(object sender, EventArgs e)
        {
            if(_motorcycle is Bike b)
            {
                _service.UpdateItem(
                    new Bike(double.Parse(txtBoxPriceEditBike.Text),
                             double.Parse(txtBoxWeightEditBike.Text),
                             int.Parse(txtBoxPassAmountEditBike.Text),
                             DateTime.Parse(txtboxManfactorEditBike.Text),
                             /*double.Parse(txtBoxPricePerEditBike.Text)*/ 34,
                             comboBoxIsRentEditBike.SelectedIndex == 0 ? true : false,
                             int.Parse(txtBoxKnotEditBike.Text),
                             comboBoxDependedEditBike.SelectedIndex == 0 ? true : false
                             ), _motorcycle.Id);
            }
            else if(_motorcycle is ATV a)
            {
                _service.UpdateItem(
                   new ATV(double.Parse(txtBoxPriceEditBike.Text),
                            double.Parse(txtBoxWeightEditBike.Text),
                            int.Parse(txtBoxPassAmountEditBike.Text),
                            DateTime.Parse(txtboxManfactorEditBike.Text),
                            /*double.Parse(txtBoxPricePerEditBike.Text)*/34,
                            comboBoxIsRentEditBike.SelectedIndex == 0 ? true : false,
                            int.Parse(txtBoxKnotEditBike.Text),
                            comboBoxDependedEditBike.SelectedIndex == 0 ? true : false), _motorcycle.Id);
            }
            this.Close();
        }

        private void GenerateFields(Motorcycle motorcycle)
        {
            this.txtBoxPriceEditBike.Text = motorcycle.PricePerDay.ToString();
            this.txtBoxWeightEditBike.Text = motorcycle.Weight.ToString();
            this.txtBoxPassAmountEditBike.Text = motorcycle.PassangerAmount.ToString();
            //this.txtBoxImageEditBike.Text = motorcycle.ImageUri.ToString();
            this.txtboxManfactorEditBike.Text = motorcycle.ManufactorDate.ToString();
            this.comboBoxIsRentEditBike.SelectedIndex = motorcycle.IsRentedNow ? 0 : 1;
            this.txtBoxKnotEditBike.Text = motorcycle.MaxSpeed.ToString();

            if (motorcycle is Bike b)
            {
                this.lblDependedEditBike.Text = "Sport Bike ?";
                this.comboBoxDependedEditBike.SelectedIndex = b.IsSport ? 0 : 1;
            }
            else if(motorcycle is ATV a)
            {
                this.lblDependedEditBike.Text = "Dirty ?";
                this.comboBoxDependedEditBike.SelectedIndex = a.IsDirt ? 0 : 1;
            }
        }

    }
}
