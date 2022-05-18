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
        public bool IsDirt { get; set; }

        public ATV(double price, double wight,int maxSpeed, bool Isdirt) : base(price, wight,maxSpeed)
        {
            IsDirt = Isdirt;
        }
    }
}
