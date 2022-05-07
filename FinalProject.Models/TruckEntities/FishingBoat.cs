﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.TruckEntities
{
    [Serializable]
    public class FishingBoat : Boat
    {
        public int NumberOfHooks { get; set; }
        public FishingBoat(double price, double wight, int maxSpeed, bool isSail, int FishHooks) : base(price, wight, maxSpeed, isSail)
        {
            NumberOfHooks = FishHooks;
        }
    }
}
