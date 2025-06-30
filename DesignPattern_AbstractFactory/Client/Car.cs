using DesignPattern_AbstractFactory.CarFactory;
using DesignPattern_AbstractFactory.Fuel;
using DesignPattern_AbstractFactory.Movement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_AbstractFactory.Client
{
    public class Car
    {
        private readonly IFuel _fuel;
        private readonly IMovement _movement;

        public Car(ICarFactory factory)
        {
            _fuel = factory.CreateFuel();
            _movement = factory.CreateMovement();
        }

        public override string ToString()
        {
            return $"Car with *{_fuel.GetFuelType()}* fuel type and *{_movement.GetMovementType()}* movement type";
        }
    }
}
