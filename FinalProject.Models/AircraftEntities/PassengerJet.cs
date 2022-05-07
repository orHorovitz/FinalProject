using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.BikeEntities
{
    public class PassengerJet : Aircraft
    {
        public int Capacity { get; set; }

        public PassengerJet(double price, double wight, int maxRange, int maxHeight,int maxCapacity) : base(price, wight, maxRange, maxHeight)
        {
            Capacity = maxCapacity;
        }
    }
}
