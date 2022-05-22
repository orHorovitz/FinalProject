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

namespace Test.Controls
{
    public partial class ListItem : UserControl
    {
        private bool _flag = true;
        public Vehicle Vehicle { get; set; }
        public ListItem(Vehicle vehicle)
        {
            InitializeComponent();
            Vehicle = vehicle;
            tblId.Text = Vehicle.Id.ToString();
            tblIsRented.Text = Vehicle.IsRentedNow ? "Yes" : "No";
            tblManufactorDate.Text = Vehicle.ManufactorDate.ToString("dd/MM/yyyy");
            tblPrice.Text = Vehicle.Price.ToString();
            tblPPD.Text = Vehicle.PricePerDay.ToString();
            tlbWeight.Text = Vehicle.Weight.ToString();
            tlbPassangerAmount.Text = Vehicle.PassangerAmount.ToString();
            pbx.ImageLocation = @"https://th.bing.com/th/id/R.0cdbe50eedb719a9df3353ca226c062b?rik=XH1eV7%2ffDuYqcw&riu=http%3a%2f%2froadandmountainbikereviews.co.uk%2fwp-content%2fuploads%2f2020%2f11%2feurobike-x1.jpg&ehk=XrpBTfkmutpVCUXBAUOmiYF2NqLFGxx8fJupdTFT2I0%3d&risl=&pid=ImgRaw&r=0";
        }

        private void ListItem_Load(object sender, EventArgs e)
        {

        }

        //protected override void OnClick(EventArgs e)
        //{
        //    if (_flag)
        //    {
        //        this.BackColor = Color.Gray;
        //        _flag = false;
        //    }
        //    else
        //    {;
        //        this.BackColor = Color.White;
        //        _flag = true;
        //    }
        //}
        private void addNewItem()
        {

        }

    }
}
