using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.TruckEntities
{
    [Serializable]
    public class Yacht : Boat
    {
        public int NumberOfRoomAmount { get; set; }
        public Yacht(double price, double wight, int maxSpeed, bool isSail,int RoomAmounts) : base(price, wight, maxSpeed, isSail)
        {
            NumberOfRoomAmount = RoomAmounts;
        }
    }
}
