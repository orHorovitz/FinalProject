using FinalProject.BusinessLogic;
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
            var agancyService = new AgancyService();
            Application.Run(new Form1());
            foreach (var item in agancyService.Repository.GetAll())
            {
                MessageBox.Show($"{item.Id}");
                if(item is ElectricCar c)
                {
                    MessageBox.Show($"Hand {c.Hand}");
                }
            }
        }
        static void foo()
        {
            List<Vehicle> myList = new List<Vehicle>();
            myList.Add(new GasCar(12, "harley", 45, 3, 3.4, 340));
            myList.Add(new PassengerJet(34, "harley", 45, 4, 5.5, 5677));
            var car = new PassengerJet(34, "harley", 45, 4, 5.5, 5677);
            

            var newList = myList.OfType<PassengerJet>();


        }
    }
}
