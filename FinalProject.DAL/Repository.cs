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

        public Repository()
        {
            _filePath =Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "vehicles.bin");
            //Vehicles.SeedData();
            //SaveChanges();
            InitFromFile();
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
                this.Vehicles.Remove(vehicle);
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
    }
}
