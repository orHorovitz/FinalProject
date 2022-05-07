using FinalProject.Models;
using FinalProject.Models.BikeEntities;
using FinalProject.Models.PrivateCarEntities;
using FinalProject.Models.TruckEntities;
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

            list.Add(new GasCar(15000, "Kia", 1.15, 0, 1500, 120));
            list.Add(new SportBike(20000,"Honda",90,8 , 0.90,1));
            list.Add(new ElectricCar(149000 , "Tesla" , 1.50 , 1));
            list.Add(new FullTrack(549000 ,"Mercedes" ,2.90 ,1));
            list.Add(new SemiTrailer(349000, "Merecedes" ,2.50 , 1));

        }
    }
}
