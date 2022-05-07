using FinalProject.DAL;
using FinalProject.Models;
using FinalProject.Models.BikeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLogic
{
    public class AgancyService
    {
        public Repository Repository { get; set; }

        public AgancyService()
        {
            this.Repository = new Repository();
        }

        public void Add(Vehicle vehicle)
        {
            this.Repository.AddItem(vehicle);
        }
        public List<PassengerJet> findalllightbikes()
        {
           return Repository.GetAll().OfType<PassengerJet>().ToList();
        }
        public void foo()
        {

        }
            
            
    }
}
