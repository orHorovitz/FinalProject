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
        bool AddItem(Vehicle vehicle);
        Vehicle Update(Vehicle vehicle,int id);
        Vehicle Delete(int id);
    }
}
