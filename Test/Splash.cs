using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int startPoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            ProgressBar.Increment(1);
            if(ProgressBar.Value == 100)
            {
                timer1.Enabled=false;
                ChildForms.LoginPage loginPage = new ChildForms.LoginPage();
                loginPage.Show();
                this.Hide();
            }
        }
    }

}
