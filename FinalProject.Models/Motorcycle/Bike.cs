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
        public bool IsSport{ get; set; }

        public Bike(double price, double wight,int maxSpeed,bool isSport) : base(price, wight,maxSpeed)
        {
            IsSport = IsSport;
        }
    }
}
