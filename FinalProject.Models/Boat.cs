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
        public Boat(double price, double weight, int passangerAmount, DateTime manufactorDate, double pricePerDay, bool isRentedNow,int knot,string imageUri) : base(price, weight, passangerAmount, manufactorDate, pricePerDay, isRentedNow,imageUri)
        {
               Knot= knot;
        }

        public int Knot { get; set; }
        



    }

}
