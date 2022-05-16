using FinalProject.Models.Enums;
using System;
using System.Windows.Forms;

namespace Test.ChildForms.AddForms
{
    public partial class AddCarForm : Form
    {
        private string[] _categories;
        public string TypeName { get; private set; }
        public AddCarForm()
        {
            InitializeComponent();
            _categories = Enum.GetNames(typeof(Cars));
            cmbTypes.Items.AddRange(_categories);
            cmbTypes.SelectedIndexChanged += CmbTypes_SelectedIndexChanged;
        }

        private void CmbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox cmb)
            {
                TypeName = cmb.SelectedItem.ToString();
                RenderForm();
            }
        }

        private void RenderForm()
        {
            //gb.Controls.Clear();
            var lblPrice = new Label();
            lblPrice.Text = "Price";
            var tbxPrice = new Label();

            var lblweight = new Label();
            lblweight.Text = "Weight";
            var tbxweight = new TextBox();

            var lbMilage = new Label();
            lbMilage.Text = "Milage";
            var tbxMilage = new TextBox();

            gb.Controls.Add(lblPrice);
            gb.Controls.Add(tbxPrice);
            gb.Controls.Add(lblweight);
            gb.Controls.Add(tbxweight);
            gb.Controls.Add(lbMilage);
            gb.Controls.Add(tbxMilage);
            

            if (TypeName == "GasCar")
            {
                var lblFuel= new Label();
                lblFuel.Text = "Fuel";
                var tbxFuel = new TextBox();

                gb.Controls.Add(lblFuel);
                gb.Controls.Add(tbxFuel);
            }
            else
            {
                var lblPower = new Label();
                lblPower.Text = "Power";
                var tbxPower = new TextBox();

                gb.Controls.Add(lblPower);
                gb.Controls.Add(tbxPower);
            }
        }
    }
}
