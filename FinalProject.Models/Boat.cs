using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    [Serializable]
    public abstract class Boat : Vehicle
    {
        public int MaxSpeed { get; set; }
        public bool IsSailBoat { get; set; }
        protected Boat(double price, double wight,int maxSpeed,bool isSail) : base(price, wight)
        {
            MaxSpeed = maxSpeed;
            IsSailBoat = isSail;
        }



    }

}
