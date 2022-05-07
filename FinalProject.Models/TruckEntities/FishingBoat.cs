using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.TruckEntities
{
    public class FishingBoat : Boat
    {
        public FishingBoat(double price, double wight, int maxSpeed, bool isSail) : base(price, wight, maxSpeed, isSail)
        {
        }
    }
}
