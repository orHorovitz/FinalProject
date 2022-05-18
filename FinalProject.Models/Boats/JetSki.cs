using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.BoatEntities//was TruckEntities
{
    [Serializable]
    public class JetSki : Boat
    {
        public bool IsWaterJet { get; set; }
        public JetSki(double price, double wight, int knot,bool isWaterJet) : base(price, wight, knot)
        {
            IsWaterJet = isWaterJet;
        }
    }
}
