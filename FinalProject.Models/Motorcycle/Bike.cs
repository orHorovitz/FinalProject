using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.BikeEntities
{
    [Serializable]
    public class Bike : Motorcycle
    {
        public Bike(double price, double weight, int passangerAmount, DateTime manufactorDate, double pricePerDay, bool isRentedNow, int maxSpeed, bool isSport, Uri imageUri) : base(price, weight, passangerAmount, manufactorDate, pricePerDay, isRentedNow, maxSpeed, imageUri)
        {
            IsSport = isSport;
        }

        public bool IsSport{ get; set; }

        
    }
}
