using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.BoatEntities
{
    [Serializable]
    public class Yacht : Boat
    {
        public Yacht(double price, double weight, int passangerAmount, DateTime manufactorDate, double pricePerDay, bool isRentedNow, int knot, int numberOfRoomAmount,Uri imageUri) : base(price, weight, passangerAmount, manufactorDate, pricePerDay, isRentedNow, knot, imageUri)
        {
            NumberOfRoomAmount = numberOfRoomAmount;
        }

        public int NumberOfRoomAmount { get; set; }
        
    }
}
