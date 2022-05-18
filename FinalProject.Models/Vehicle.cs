using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    [Serializable]
    public abstract class Vehicle
    {
        public static int _id=1;
        public int Id { get; set; }
        public double Price { get; set; }
        public double PricePerDay { get; set; }
        public DateTime ManufactorDate { get; set; }
        public bool IsRentedNow { get; set; } = false;
        public double Weight { get; set; }
        public int PassangerAmount { get; set; }


        public Vehicle(double price,double weight)
        {
            this.Price = price;
            this.Weight = weight;
            this.PassangerAmount = PassangerAmount;
            this.Id = Vehicle._id;
            Vehicle._id += 1;
            this.ManufactorDate = ManufactorDate;
            this.PricePerDay = PricePerDay;
            this.IsRentedNow = IsRentedNow;
          
        }
    }
}
