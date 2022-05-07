using FinalProject.BusinessLogic;
using FinalProject.Forms;
using FinalProject.Models;
using FinalProject.Models.BikeEntities;
using FinalProject.Models.PrivateCarEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProductsForm());
        }
       
    }
}
