using CarAPI.Models;
using CarAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarRepository _cars;
        private readonly ILogger<CarsController> _logger;

        public CarsController(ICarRepository cars, ILogger<CarsController> logger)
        {
            _cars = cars;
            _logger = logger;
        }

        [HttpGet("GetAllCars")]
        public IEnumerable<Car> GetAll()
        {
            return _cars.GetAll();
        }

        [HttpGet("GetAllCars/ByColor")]
        public IEnumerable<Car> GetByColor([FromQuery] string colorToGet)
        {
            return _cars.GetByColor(colorToGet);
        }

        [HttpPost]
        public void Post([FromBody] CarDTO carToAddDTO)
        {
            _cars.AddCar(carToAddDTO);
        }

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] CarDTO carDTO)
        {
            _cars.UpdateById(id, carDTO);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _logger.LogInformation($"{Request.HttpContext.Connection.RemoteIpAddress} requested to remove Car {id}");
            _cars.RemoveById(id);
        }
    }
}
