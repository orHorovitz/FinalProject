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
        public int NumberOfRoomAmount { get; set; }
        public Yacht(double price, double wight, int knot,int RoomAmounts) : base(price, wight, knot)
        {
            NumberOfRoomAmount = RoomAmounts;
        }
    }
}
