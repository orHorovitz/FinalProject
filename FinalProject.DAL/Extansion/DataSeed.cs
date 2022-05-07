﻿using FinalProject.Models;
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

            list.Add(new GasCar(12,14,12,42));
            list.Add(new Yacht(12,12,12,true,12)) ;
            list.Add(new ElectricCar(11,34,5,6));
            list.Add(new FishingBoat (44,43,3,true,1));
            list.Add(new FighterJet(12,13,14,15,16));
            list.Add(new PassengerJet(33,566,75,34,3));


        }
    }
}
