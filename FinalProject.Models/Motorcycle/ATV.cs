using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.BikeEntities
{
    [Serializable]
    public class ATV : Motorcycle
    {
        public int MaxArmamentWeight { get; set; }
        public ATV(double price, double wight, int maxRange, int maxHeight,int maxArmament) : base(price, wight, maxRange, maxHeight)
        {
            MaxArmamentWeight = maxArmament;
        }
    }
}
