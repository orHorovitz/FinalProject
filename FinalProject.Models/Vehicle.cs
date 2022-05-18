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
        public static int StaticId { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        public double PricePerDay { get; set; }
        public DateTime ManufactorDate { get; set; }
        public bool IsRentedNow { get; set; } = false;
        public double Weight { get; set; }
        public int PassangerAmount { get; set; }
        public string ImageUri { get; set; }



        public Vehicle(double price, double weight, int passangerAmount, DateTime manufactorDate, double pricePerDay, bool isRentedNow, string imageUri)
        {
            this.Price = price;
            this.Weight = weight;
            this.PassangerAmount = passangerAmount;
            this.Id = Vehicle.StaticId;
            Vehicle.StaticId += 1;
            this.ManufactorDate = manufactorDate;
            this.PricePerDay = pricePerDay;
            this.IsRentedNow = isRentedNow;
            ImageUri = imageUri;
        }
    }
}
