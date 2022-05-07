using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public abstract class Vehicle
    {
        public static int _id=1;
        public int Id { get; set; }
        public double Price { get; set; }
        public double Wight { get; set; }
        public int PassangerAmount { get; set; }


        public Vehicle(double price,double wight)
        {
            this.Price = price;
            this.Wight = wight;
            this.PassangerAmount = PassangerAmount;
            this.Id = Vehicle._id;
            Vehicle._id += 1;
        }
    }
}
