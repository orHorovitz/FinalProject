using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.PrivateCarEntities
{
    public class ElectricCar : PrivateCar
    {
        public ElectricCar(double price, double wight, int mileage) : base(price, wight, mileage)
        {
        }
    }
}
