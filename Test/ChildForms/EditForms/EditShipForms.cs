using FinalProject.BusinessLogic;
using FinalProject.Models;
using FinalProject.Models.BoatEntities;
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
    public partial class EditShipForms : Form
    {
        private readonly Boat _boat;
        private readonly AgancyService _service;
        public EditShipForms(Boat boat)
        {
            InitializeComponent();
            this._boat = boat;
            _service = new AgancyService();
            GenerateFields(_boat);
            btnEditShips.Click += btnEditShips_Click;
        }

        private void GenerateFields(Boat boat)
        {
            this.txtBoxPriceEditBoat.Text = boat.PricePerDay.ToString();
            this.txtBoxWeightEditBoat.Text = boat.Weight.ToString();
            this.txtBoxPassAmountEditBoat.Text = boat.PassangerAmount.ToString();
            //this.txtBoxImageEditBike.Text = motorcycle.ImageUri.ToString();
            this.txtboxManfactorEditBoat.Text = boat.ManufactorDate.ToString();
            this.comboBoxIsRentEditBoat.SelectedIndex = boat.IsRentedNow ? 0 : 1;
            this.txtBoxKnotEditBoat.Text = boat.Knot.ToString();

            if (boat is JetSki b)
            {
                this.txtboxRoomAmountEditBoat.Text = "is waterJet ?";
                this.comboBoxIsWaterJet.SelectedIndex = b.IsWaterJet ? 0 : 1;
            }
            else if (boat is Yacht a)
            {
                this.txtboxRoomAmountEditBoat.Text = "Number of Rooms ?";
                this.txtboxRoomAmountEditBoat.Text = a.NumberOfRoomAmount.ToString();
            }
        }


        private void btnEditShips_Click(object sender, EventArgs e)
        {
            if (_boat is JetSki b)
            {
                _service.UpdateItem(
                    new JetSki(double.Parse(txtBoxPriceEditBoat.Text),
                             double.Parse(txtBoxWeightEditBoat.Text),
                             int.Parse(txtBoxPassAmountEditBoat.Text),
                             DateTime.Parse(txtboxManfactorEditBoat.Text),
                             /*double.Parse(txtBoxPricePerEditBike.Text)*/ 34,
                             comboBoxIsRentEditBoat.SelectedIndex == 0 ? true : false,
                             int.Parse(txtBoxKnotEditBoat.Text),
                             comboBoxIsWaterJet.SelectedIndex == 0 ? true : false
                             ), _boat.Id);
            }
            else if (_boat is Yacht a)
            {
                var price = double.Parse(txtBoxPriceEditBoat.Text);
                var Weight = double.Parse(txtBoxWeightEditBoat.Text);
                var Amount = int.Parse(txtBoxPassAmountEditBoat.Text);
                var Manufactord = DateTime.Parse(txtboxManfactorEditBoat.Text);
                var IsRent = comboBoxIsRentEditBoat.SelectedIndex == 0 ? true : false;
                var Knot = int.Parse(txtBoxKnotEditBoat.Text);
                var RoomAmount = int.Parse(txtboxRoomAmountEditBoat.Text);




                try
                {
                    _service.UpdateItem(
                              new Yacht(price,
                                       Weight,
                                       Amount,
                                       Manufactord,
                                       /*double.Parse(txtBoxPricePerEditBoat.Text)*/34,
                                       IsRent,
                                       Knot,
                                       RoomAmount)
                              , _boat.Id);
                }
                catch (Exception ex)
                {

                   MessageBox.Show(ex.Message) ;
                }
            }
            this.Close();
        }

        
    }
}
