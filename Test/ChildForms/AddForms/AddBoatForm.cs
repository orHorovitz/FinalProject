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
        public string TypeName { get; private set; }

        public AddBoatForm()
        {
            
            InitializeComponent();
            _categories = Enum.GetNames(typeof(Boats));
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
            lblKnotBoat.Text = "Knot :";
            lblPriceBoat.Text = "Price : ";
            lblWightBoat.Text = "Wight :";
            if(this.comboBoxChoose.SelectedIndex == 1)
            {
                lblTypeDepended.Text = "IsWaterJet :";

            }
            else if(this.comboBoxChoose.SelectedIndex == 2)
            {
                lblTypeDepended.Text = "Amount of room :";
                txtBoxTypeDepended.Location = new Point(461, 283);
                pnlDepended.Location = new Point(462, 283);
            }
                

            
        }
    }
}

