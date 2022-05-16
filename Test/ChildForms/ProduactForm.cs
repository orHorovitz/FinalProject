using FinalProject.BusinessLogic;
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
using Test.ChildForms.AddForms;

namespace Test.ChildForms
{
    public partial class ProduactForm : Form
    {
        public List<Vehicle> Vehicles { get; set; }
        public List<Vehicle> FilteredVehicles { get; set; }
        public Vehicle SelectedItem { get; set; }
        public string HeaderName { get;private set; }
        private string[] _categories = new string[100];

        public Type CurrentType { get;  set; }

        private readonly AgancyService _agancy;

        public ProduactForm(List<Vehicle> items,string headerName)
        {
            InitializeComponent();
            Vehicles = items;
            FilteredVehicles = Vehicles;
            HeaderName = headerName;
            lblHeader.Text = headerName;
            _agancy = new AgancyService();
            this.InitForm();
        }

        private void InitForm()
        {
            comboBoxList.Items.Clear();
            GetTypesList();
            comboBoxList.Items.AddRange(_categories);
            comboBoxList.SelectedIndexChanged += ComboBoxList_SelectedIndexChanged;
            lvItems.SelectedIndexChanged += LvItems_SelectedIndexChanged;
            btnAdd.Click += BtnAdd_Click;
            btnDelete.Click += BtnDelete_Click;
            btnEdit.Click += BtnEdit_Click;
            if (lvItems.SelectedItems.Count != 1)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            RenderItemsOnStart();
        }

        private void LvItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (ListView)sender;
            var id = int.Parse(item.SelectedItems[0].Text);
            SelectedItem = Vehicles.Find(v => v.Id == id);
            btnDelete.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedItem != null)
            {
                var result = MessageBox.Show("Are You Sure ? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _agancy.DeleteItem(SelectedItem.Id);
                    Vehicles.Remove(Vehicles.Find(v => v.Id == SelectedItem.Id));
                    RenderItemsOnChange();
                }
                else return;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            switch(HeaderName)
            {
                case "Car":
                    var window = new AddCarForm();
                    window.FormClosed += Window_FormClosed;
                    window.Show();
                    this.Enabled = false;
                    break;
                case "Motorcycle":
                    var window2 = new AddBikeForm();
                    window2.FormClosed += Window_FormClosed;
                    window2.Show();
                    this.Enabled = false;
                    break;
                case "Boat":
                    var window3 = new AddBoatForm();
                    window3.FormClosed += Window_FormClosed;
                    window3.Show();
                    this.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void Window_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        private void ComboBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sender is ComboBox cmb)
            {
                string typeName = cmb.SelectedItem.ToString();
                FilteredVehicles = Vehicles
                    .FindAll(v => {
                        var itemType = v.GetType().ToString().Split('.').Last();
                        return itemType == typeName;
                    });
                RenderItemsOnChange();
            }
        }
        private void RenderItemsOnStart()
        {
            foreach (var v in Vehicles)
            {
                lvItems.Items.Add(v.Id.ToString());
            }
        }
        private void RenderItemsOnChange()
        {
            lvItems.Items.Clear();
            foreach (var v in FilteredVehicles)
            {
                lvItems.Items.Add(v.Id.ToString());
            }
        }

        private void GetTypesList()
        {
            switch (HeaderName)
            {
                case "Car":
                    _categories = Enum.GetNames(typeof(Cars));
                    CurrentType = typeof(PrivateCar);
                    break;
                case "Motorcycle":
                    _categories = Enum.GetNames(typeof(Motorcycles));
                    CurrentType = typeof(Motorcycle);
                    break;
                case "Boat":
                    _categories = Enum.GetNames(typeof(Boats));
                    CurrentType = typeof(Boat);
                    break;
                default:
                    break;
            }

        }

        private void comboBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChildFormpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
