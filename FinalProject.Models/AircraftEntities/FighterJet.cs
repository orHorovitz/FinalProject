using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.BikeEntities
{
    public class FighterJet : Aircraft
    {
        public int MaxArmamentWeight { get; set; }
        public FighterJet(double price, double wight, int maxRange, int maxHeight,int maxArmament) : base(price, wight, maxRange, maxHeight)
        {
            MaxArmamentWeight = maxArmament;
        }
    }
}
