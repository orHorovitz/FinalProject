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
        public Bike(double price, double weight, int passangerAmount, DateTime manufactorDate, double pricePerDay, bool isRentedNow, int maxSpeed, bool isSport) : base(price, weight, passangerAmount, manufactorDate, pricePerDay, isRentedNow, maxSpeed)
        {
            IsSport = isSport;
        }

        public bool IsSport{ get; set; }

        
    }
}
