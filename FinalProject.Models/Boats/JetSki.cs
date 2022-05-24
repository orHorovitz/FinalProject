using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.BoatEntities
{
    [Serializable]
    public class JetSki : Boat
    {
        public JetSki(double price, double weight, int passangerAmount, DateTime manufactorDate, double pricePerDay, bool isRentedNow, int knot, bool isWaterJet) : base(price, weight, passangerAmount, manufactorDate, pricePerDay, isRentedNow, knot)
        {
            IsWaterJet = isWaterJet;
        }

        public bool IsWaterJet { get; set; }
        
    }
}
