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
        public int Knot { get; set; }
        protected Boat(double price, double wight,int knot) : base(price, wight)
        {
            Knot = knot;
        }



    }

}
