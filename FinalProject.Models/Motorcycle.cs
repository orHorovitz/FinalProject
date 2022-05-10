using FinalProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    [Serializable]
    public abstract class Motorcycle : Vehicle
    {
        public int MaxRange { get; set; }
        public int MaxHeight { get; set; }
        public Motorcycle(double price, double wight,int maxRange,int maxHeight) : base(price, wight)
        {
            MaxHeight = maxHeight;
            MaxRange = maxRange;
        }
    }



}
