using FinalProject.DAL.Extansion;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalProject.DAL
{
  
    public class Repository : IRepository
    {
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        private readonly string _filePath;
        private static Repository instance = null;
        public event EventHandler<EventArgs> RepositoryChanged;

         private Repository()
        {
            _filePath =Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "vehiclesp.bin");
            Vehicles.SeedData();
            SaveChanges();
            InitFromFile();
            GetLastId();
        }

        private void GetLastId()
        {
            List<int> ids = new List<int>();
            foreach (var item in GetAll())
            {
                ids.Add(item.Id);
            }
            var biggest = ids.Max();
            Vehicle.StaticId = ++biggest;
        }

        private void InitFromFile()
        {
            using (var reader = File.Open(_filePath,FileMode.OpenOrCreate))
            {
                var formatter = new BinaryFormatter();
                if(reader.Length >0)
                {
                    Vehicles = (List<Vehicle>)formatter.Deserialize(reader);
                }
            }
        }


        public bool AddItem(Vehicle vehicle)
        {
            try
            {
                Vehicles.Add(vehicle);
                SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Vehicle Delete(int id)
        {
            var vehicle = Vehicles.FirstOrDefault(v => v.Id == id);
            if (vehicle != null)
            {
                Vehicles.Remove(vehicle);
                SaveChanges();
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

        public Vehicle Update(Vehicle vehicle,int id)
        {
            var existingVehicle = Vehicles.FirstOrDefault(v => v.Id == id);
            if (existingVehicle != null)
            {
                vehicle.Id = id;
                existingVehicle = vehicle;
                return vehicle;
            }
            else throw new Exception("Not Found");

        }

        private void SaveChanges()
        {
            using (var reader = File.Open(_filePath, FileMode.OpenOrCreate))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(reader, Vehicles);
            }
        }

        public static Repository GetInstance()
        {
            if(instance == null)
            {
                instance = new Repository();
            }
            return instance;
        }
    }
}
