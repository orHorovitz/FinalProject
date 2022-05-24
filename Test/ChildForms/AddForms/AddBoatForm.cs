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
    public partial class AddBoatForm : Form
    {
        private string[] _categories;
        private readonly FinalProject.BusinessLogic.AgancyService _agancy;
        private IVehicleView view;
        public string TypeName { get; private set; }
        public AddBoatForm(FinalProject.BusinessLogic.AgancyService _agancy, IVehicleView view)
        {
            
            InitializeComponent();
            MakeItFalse();
            this.view = view;
            this._agancy = _agancy;
            //_categories = Enum.GetNames(typeof(Boats));
            //cmdType.Items.AddRange(_categories);
        }


        private void cmdType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox cmb)
            {
                TypeName = cmb.SelectedItem.ToString();
                RenderForm();
            }

        }
        private void RenderForm()
        {
            if (TypeName == "JetSki")
            {

            }
            else
            {

            }
        }

        private void btnRefrash_Click(object sender, EventArgs e)
        {

            
            if(this.comboBoxChoose.SelectedIndex == 1)
            {

                lblDependedB.Text = "IsWaterJet:";
                lblKnotB.Text = "Knot :";
                lblDependedB.Location = new Point(477, 338);
                lblPleaseChooseType.Visible = false;
                MakeItTrue();
                txtBoxDependedB.Hide();
                lbl___Depended.Hide();
                this.comboBoxDependedBoat.Show();


            }
            else if(this.comboBoxChoose.SelectedIndex == 2)
            {
                lblDependedB.Text = "Room Amount:";
                lblKnotB.Text = "Knot :";
                lblDependedB.Location = new Point(448, 338);
                lblPleaseChooseType.Visible = false;
                MakeItTrue(); 
                this.comboBoxDependedBoat.Hide();
                txtBoxDependedB.Show();
                lbl___Depended.Show();
            }
            
        }



        //private void AddBoatForm_Load(object sender, EventArgs e)
        //{
        //    this.Close();
        //    FinalProject.Models.Vehicle NewBoat = null;
        //    double Price = Double.Parse(txtBoxPriceB.Text);
        //    double Weight = double.Parse(txtBoxWeightB.Text);
        //    int PassangerAmount = int.Parse(txtBoxPassAmountB.Text);
        //    DateTime dateTime = DateTime.Parse(txtBoxManufactorB.Text);
        //    double PricePerDay = double.Parse(lblPricePerDayB.Text);
        //    bool isRend = false;
        //    bool IsWaterJet = false;
        //    if (txtBoxIsRendB != null)
        //    {
        //        isRend = true;
        //    }
        //    int Knot = int.Parse(txtBoxKnotB.Text);
        //    string Url = txtBoxImageB.Text;
        //    if (comboBoxChoose.SelectedIndex == 1)
        //    {
        //        if(txtBoxDependedB.Text != null)
        //        {
        //            IsWaterJet = true;
        //        }
        //        NewBoat = new FinalProject.Models.BoatEntities.JetSki(Price ,Weight , PassangerAmount , dateTime , PricePerDay , isRend , Knot , IsWaterJet , Url);
        //    }
        //    else if (comboBoxChoose.SelectedIndex == 2)
        //    {
        //        int RoomAmount = int.Parse(txtBoxDependedB.Text);
        //        NewBoat = new FinalProject.Models.BoatEntities.Yacht(Price, Weight, PassangerAmount, dateTime, PricePerDay, isRend, Knot, RoomAmount, Url);
        //    }

        //    //return newCar;
        //    //Adding Item
        //    if (_agancy.Add(NewBoat))
        //    {
        //        view.AddVehicle(NewBoat);
        //    }

        //    this.Close();
        //}

        private void MakeItFalse()
        {
            lblPriceB.Visible = false;
            lblDependedB.Visible = false;
            lblPricePerDayB.Visible = false;
            lblWeightB.Visible = false;
            lblIsRendB.Visible = false;
            lblKnotB.Visible = false;
            lblManufactorB.Visible = false;
            lblPassAmountB.Visible = false;
            lbl__1.Visible = false;
            lbl__2.Visible = false;
            comboBoxIsRentBoat.Visible = false;
            lbl__4.Visible = false;
            lbl__6.Visible = false;
            lbl__7.Visible = false;
            lbl__8.Visible = false;
            comboBoxDependedBoat.Visible=false;
            lbl___Depended.Visible = false;



        }
        private void MakeItTrue()
        {
            lblPriceB.Visible = true;
            lblDependedB.Visible = true;
            lblPricePerDayB.Visible = true;
            lblWeightB.Visible = true;
            lblIsRendB.Visible = true;
            lblKnotB.Visible = true;
            lblManufactorB.Visible = true;
            lblPassAmountB.Visible = true;
            lbl__1.Visible = true;
            lbl__2.Visible = true;
            comboBoxIsRentBoat.Visible=true;
            comboBoxDependedBoat.Visible= true;
            lbl__4.Visible = true;
            lbl__6.Visible = true;
            lbl__7.Visible = true;
            lbl__8.Visible = true;
            lbl___Depended.Visible = true;


        }

        private void btnAddBoat_Click(object sender, EventArgs e)
        {
            
            FinalProject.Models.Vehicle NewBoat = null;
            double Price = double.Parse(txtBoxPriceB.Text);
            double Weight = double.Parse(txtBoxWeightB.Text);
            int PassangerAmount = int.Parse(txtBoxPassAmountB.Text);
            DateTime dateTime = DateTime.Parse(txtBoxManufactorB.Text);
            double PricePerDay = double.Parse(txtBoxPricePerB.Text);
            bool isRend;
            bool IsWaterJet;
            if (comboBoxIsRentBoat.SelectedIndex == 0)
            {
                isRend = true;
            }
            else
            {
                isRend=false;
            }
            int Knot = int.Parse(txtBoxKnotB.Text);
            if (comboBoxChoose.SelectedIndex == 1)
            {
                if (comboBoxDependedBoat.SelectedIndex == 1)
                {
                    IsWaterJet = true;
                }
                else
                {
                    IsWaterJet = false;
                }
                NewBoat = new FinalProject.Models.BoatEntities.JetSki(Price, Weight, PassangerAmount, dateTime, PricePerDay, isRend, Knot, IsWaterJet);
            }
            else if (comboBoxChoose.SelectedIndex == 2)
            {

                int RoomAmount = int.Parse(txtBoxDependedB.Text);
                NewBoat = new FinalProject.Models.BoatEntities.Yacht(Price, Weight, PassangerAmount, dateTime, PricePerDay, isRend, Knot, RoomAmount);
            }

            //return newCar;
            //Adding Item
            if (_agancy.Add(NewBoat))
            {
                view.AddVehicle(NewBoat);
            }

            this.Close();
        }
    }
}

