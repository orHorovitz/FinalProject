using FinalProject.DAL;
using FinalProject.Models;
using FinalProject.Models.BikeEntities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.BusinessLogic
{
    public class AgancyService
    {
        private readonly Repository _repo;

        public AgancyService()
        {
            this._repo = new Repository();
        }

        public bool Add(Vehicle vehicle)
        {
            return this._repo.AddItem(vehicle);
        }
        public Vehicle DeleteItem(int id)
        {
            try
            {
                return this._repo.Delete(id);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Vehicle UpdateItem(Vehicle vehicle , int id)
        {
            try
            {
                return _repo.Update(vehicle, id);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<Vehicle> GetAllItems()
        {
            return _repo.GetAll().ToList();
        }
        public List<T> GetByType<T>()
        {
            return _repo.GetAll().OfType<T>().ToList();
        }
    }
}
