using FinalProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.PrivateCarEntities
{
    [Serializable]
    public class GasCar : PrivateCar
    {
        public GasCar(double price, double weight, int passangerAmount, DateTime manufactorDate, double pricePerDay, bool isRentedNow, int mileage,double fuelStorage, string imageUri) : base(price, weight, passangerAmount, manufactorDate, pricePerDay, isRentedNow, mileage, imageUri)
        {
            FuelStorage = fuelStorage;
        }

        public double FuelStorage { get; set; }

       
    }
}
