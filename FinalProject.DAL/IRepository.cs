using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAL
{
    interface IRepository
    {
        IEnumerable<Vehicle> GetAll();
        void AddItem(Vehicle vehicle);
        Vehicle Update(Vehicle vehicle);
        Vehicle Delete(int id);
    }
}
