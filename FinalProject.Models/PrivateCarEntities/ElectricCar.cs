using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.PrivateCarEntities
{
    [Serializable]
    public class ElectricCar : PrivateCar
    {
        public ElectricCar(double price, double weight, int passangerAmount, DateTime manufactorDate, double pricePerDay, bool isRentedNow, int mileage,double power, string imageUri) : base(price, weight, passangerAmount, manufactorDate, pricePerDay, isRentedNow, mileage, imageUri)
        {
            Power = power;
        }

        public double Power { get; set; }

        
    }
}
