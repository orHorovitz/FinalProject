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
        public int MaxSpeed { get; set; }

        public Motorcycle(double price, double wight,int maxSpeed) : base(price, wight)
        {
            MaxSpeed = maxSpeed;
        }
    }



}
