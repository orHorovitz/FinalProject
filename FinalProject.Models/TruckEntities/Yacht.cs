using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.TruckEntities
{
    public class Yacht : Boat
    {
        public Yacht(double price, double wight, int maxSpeed, bool isSail) : base(price, wight, maxSpeed, isSail)
        {
        }
    }
}
