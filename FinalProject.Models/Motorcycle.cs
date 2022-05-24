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
        public Motorcycle(double price, double weight, int passangerAmount, DateTime manufactorDate, double pricePerDay, bool isRentedNow, int maxSpeed) : base(price, weight, passangerAmount, manufactorDate, pricePerDay, isRentedNow)
        {
            MaxSpeed = maxSpeed;
        }

        public int MaxSpeed { get; set; }

        
    }



}
