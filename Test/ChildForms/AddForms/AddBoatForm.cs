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
            cmdType.Items.AddRange(_categories);
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
    }
}
