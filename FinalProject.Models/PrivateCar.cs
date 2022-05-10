using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    [Serializable]
    public abstract class PrivateCar : Vehicle
    {
        public int Mileage { get; set; }
        public PrivateCar(double price, double wight,int mileage) : base(price, wight)
        {
            Mileage = mileage;
        }
    }

}
