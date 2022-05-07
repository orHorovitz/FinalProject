using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.BikeEntities
{
    public class FighterJet : Aircraft
    {
        public FighterJet(double price, double wight, int maxRange, int maxHeight) : base(price, wight, maxRange, maxHeight)
        {
        }
    }
}
