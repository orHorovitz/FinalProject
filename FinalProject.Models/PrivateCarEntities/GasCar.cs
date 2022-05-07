using FinalProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.PrivateCarEntities
{
    public class GasCar : PrivateCar
    {
        public GasCar(double price, double wight, int mileage) : base(price, wight, mileage)
        {
        }
    }
}
