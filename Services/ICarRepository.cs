using CarAPI.Models;
using System;
using System.Collections.Generic;

namespace CarAPI.Services
{
    public interface ICarRepository
    {
        public IEnumerable<Car> GetAll();
        public void RemoveById(Guid idToRemove);
        public void UpdateById(Guid idToModify, CarDTO updatedDTO);
        public IEnumerable<Car> GetByColor(string colorToGet);
        public void AddCar(CarDTO carToAdd);
    }
}
