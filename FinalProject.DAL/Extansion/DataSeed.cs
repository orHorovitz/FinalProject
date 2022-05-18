using FinalProject.Models;
using FinalProject.Models.BikeEntities;
using FinalProject.Models.PrivateCarEntities;
using FinalProject.Models.BoatEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAL.Extansion
{
    static class DataSeed
    {
        public static void SeedData(this List<Vehicle> list)
        {

            list.Add(new GasCar(12,12,12,new DateTime(12,12,12),12,true,12,12));
            list.Add(new Yacht(12, 12, 12, new DateTime(12, 12, 12),12, true, 12,12));
            list.Add(new ElectricCar(11, 34, 5, new DateTime(12, 12, 12), 6,true,5,4));
            list.Add(new JetSki(44, 43, 3, new DateTime(12, 12, 12),5, true, 1,true));
            list.Add(new ATV(44, 43, 3, new DateTime(12, 12, 12), 5, true, 1, true));
            list.Add(new Bike(33, 566, 75, new DateTime(12, 12, 12), 34,true, 3,true));


        }
    }
}
