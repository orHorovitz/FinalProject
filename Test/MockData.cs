using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.BusinessLogic;
using FinalProject.Models;

namespace Test
{
    internal class MockData
    {
        private List<Vehicle> mockList;

        public void AddNew()
        {
            //mockList.Add(new FinalProject.Models.PrivateCarEntities.GasCar(price, weight, passangerAmount, manufactorDate, pricePerDay, isRentedNow, mileage, 1600, imageUri));
        }

        public List<Vehicle> getVehicles()
        {
            return this.mockList;
        }

    }
}
