using FinalProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.PrivateCarEntities
{
    [Serializable]
    public class GasCar : PrivateCar
    {
        public double FuelStorage { get; set; }

        public GasCar(double price, double wight, int mileage , double fuelStorage) : base(price, wight, mileage)
        {
            this.FuelStorage = fuelStorage;
        }
    }
}
