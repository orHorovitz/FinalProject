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
            pbx.ImageLocation = @"https://user-images.githubusercontent.com/90088412/170076671-63d06347-d9c3-4fda-88db-6e59221e8632.png";
            
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
