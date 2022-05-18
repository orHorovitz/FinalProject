﻿using FinalProject.BusinessLogic;
using FinalProject.Models;
using FinalProject.Models.BoatEntities;
using FinalProject.Models.Enums;
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
using Test.ChildForms.AddForms;
using Test.Controls;

namespace Test.ChildForms
{
    public partial class ProduactForm : Form
    {
        public List<Vehicle> Vehicles { get; set; }
        public List<Vehicle> FilteredVehicles { get; set; }
        public Vehicle SelectedItem { get; set; }
        public string HeaderName { get;private set; }
        private string[] _categories = new string[100];

        private bool _selectedFlag = false;

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
            btnAdd.Click += BtnAdd_Click;
            btnDelete.Click += BtnDelete_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Enabled = false;
            flp.AutoScroll = true;
            btnEdit.Enabled = false;
            RenderItemsOnStart();
            
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
            switch (HeaderName)
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

            ///add random without filling parameters in form
            //_agancy.Add(new GasCar(1, 4, 2, DateTime.Now, 2, true, 5, 5, "https://th.bing.com/th/id/R.0cdbe50eedb719a9df3353ca226c062b?rik=XH1eV7%2ffDuYqcw&riu=http%3a%2f%2froadandmountainbikereviews.co.uk%2fwp-content%2fuploads%2f2020%2f11%2feurobike-x1.jpg&ehk=XrpBTfkmutpVCUXBAUOmiYF2NqLFGxx8fJupdTFT2I0%3d&risl=&pid=ImgRaw&r=0"));           

            ////need to figure out how to get collection by specific type
            //Vehicles = _agancy.GetAllItems();
            //RenderItemsOnStart();
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
                var e = new ListItem(v);
                e.Click += E_Click;
                flp.Controls.Add(e);
            }
        }

        private void RenderItemsOnChange()
        {
            flp.Controls.Clear();
            foreach (var v in FilteredVehicles)
            {
                var e = new ListItem(v);
                e.Click += E_Click;
                flp.Controls.Add(e);
            }
        }
        private void E_Click(object sender, EventArgs e)
        {
            if(sender is ListItem li)
            {
                if (!_selectedFlag)
                {
                    this.SelectedItem = li.Vehicle;
                    li.BackColor = Color.Gray;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                    _selectedFlag = true;
                }
                else
                {
                    li.BackColor = Color.White;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    _selectedFlag = false;
                }
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
    }
}
