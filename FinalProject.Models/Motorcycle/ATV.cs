using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.BikeEntities
{
    [Serializable]
    public class ATV : Motorcycle
    {
        public ATV(double price, double weight, int passangerAmount, DateTime manufactorDate, double pricePerDay, bool isRentedNow, int maxSpeed, bool isDirt, Uri imageUri) : base(price, weight, passangerAmount, manufactorDate, pricePerDay, isRentedNow, maxSpeed,imageUri)
        {
            IsDirt = isDirt;
        }

        public bool IsDirt { get; set; }

       
    }
}
