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

        public EditBikeForm(Motorcycle motorcycle)
        {
            InitializeComponent();
            GenerateFields(motorcycle);
            lblPleaseChooseType.Visible = false;
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
