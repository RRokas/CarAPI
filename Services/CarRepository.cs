using CarAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace CarAPI.Services
{
    public class CarRepository : ICarRepository
    {
        private readonly MssqlDbContext _context;

        public CarRepository(MssqlDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> GetAll()
        {
            return _context.Cars;
        }

        public void RemoveById(Guid idToRemove)
        {
            var carToRemove = _context.Cars.Where(c => c.Id == idToRemove).FirstOrDefault();
            _context.Cars.Remove(carToRemove);
            _context.SaveChanges();
        }

        public void UpdateById(Guid idToModify, CarDTO updatedDTO)
        {
            var carToUpdate = _context.Cars.Where(x => x.Id == idToModify).Single();

            carToUpdate.Make = updatedDTO.Make;
            carToUpdate.Color = updatedDTO.Color;
            carToUpdate.Value = updatedDTO.Value;

            _context.SaveChanges();
        }

        public IEnumerable<Car> GetByColor(string colorToGet)
        {
            return _context.Cars.Where(x => x.Color == colorToGet);
        }

        public void AddCar(CarDTO carDTO)
        {
            var carToAdd = new Car();

            carToAdd.Make = carDTO.Make;
            carToAdd.Color = carDTO.Color;
            carToAdd.Value = carDTO.Value;

            _context.Cars.Add(carToAdd);
            _context.SaveChanges();
        }
    }
}
