using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    [Serializable]
    public abstract class PrivateCar : Vehicle
    {
        public PrivateCar(double price, double weight, int passangerAmount, DateTime manufactorDate, double pricePerDay, bool isRentedNow, int mileage ,string imageUri) : base(price, weight, passangerAmount, manufactorDate, pricePerDay, isRentedNow, imageUri)
        {
            Mileage = mileage;
        }

        public int Mileage { get; set; }
       
    }

}
