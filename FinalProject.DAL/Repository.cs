using FinalProject.DAL.Extansion;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAL
{
     public class Repository : IRepository
    {
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        private const string dir = @".\Data";
        private readonly string _filePath;

        public Repository()
        {
            //InitFromFile();
            _filePath = Path.Combine(dir, "data.json");
        }

        private void InitFromFile()
        {
            ///
            Vehicles.SeedData();
        }


        public void AddItem(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }

        public Vehicle Delete(int id)
        {
            var vehicle = Vehicles.FirstOrDefault(v => v.Id == id);
            if (vehicle != null)
            {
                this.Vehicles.Remove(vehicle);
                //
                return vehicle;
            }
            else
            {
                throw new Exception("not found");
            }
        }

        public IEnumerable<Vehicle> GetAll()
        {
            return Vehicles;
        }

        public Vehicle Update(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
