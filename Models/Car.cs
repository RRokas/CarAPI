using System;

namespace CarAPI.Models
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Make { get; set; }
        public short Year { get; set; }
        public string FuelType { get; set; }
        public decimal Value { get; set; }
        public string Color { get; set; }

        public Car()
        {
            Id = Guid.NewGuid();
        }
    }
}
