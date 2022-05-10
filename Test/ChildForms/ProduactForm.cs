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

namespace Test.ChildForms
{
    public partial class ProduactForm : Form
    {
        public List<Vehicle> Vehicles { get; set; }
        public string HeaderName { get;private set; }
        private string[] _categories = new string[100];

        public ProduactForm(List<Vehicle> items,string headerName)
        {
            InitializeComponent();
            Vehicles = items;
            HeaderName = headerName;
            lblHeader.Text = headerName;
            comboBoxList.Items.Clear();
            GetTypesList();
            comboBoxList.Items.AddRange(_categories);
            comboBoxList.SelectedIndexChanged += ComboBoxList_SelectedIndexChanged;
        }

        private void ComboBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sender is ComboBox cmb)
            {
                string typeName = cmb.SelectedItem.ToString();
                var filteredVehicles = Vehicles
                    .FindAll(v => {
                        var itemType = v.GetType().ToString().Split('.').Last();
                        return itemType == typeName;
                    });
            }
        }

        private void foo()
        {
            List<ListViewItem> list = new List<ListViewItem>();
            ListView lv = new ListView();
            foreach (var item in Vehicles)
            {
                list.Add(new ListViewItem() { Text = item.Price.ToString() });
            }
            lv.Items.AddRange(list.ToArray());
        }
        private void GetTypesList()
        {
            switch (HeaderName)
            {
                case "Car":
                    _categories = Enum.GetNames(typeof(Cars));
                    break;
                case "Motorcycle":
                    _categories = Enum.GetNames(typeof(Motorcycles));
                    break;
                case "Boat":
                    _categories = Enum.GetNames(typeof(Boats));
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
