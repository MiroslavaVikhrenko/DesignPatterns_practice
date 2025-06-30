using DesignPattern_AbstractFactory.Fuel;
using DesignPattern_AbstractFactory.Movement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_AbstractFactory.CarFactory
{
    public class DieselSwimCarFactory : ICarFactory
    {
        public IFuel CreateFuel() => new DieselFuel();
        public IMovement CreateMovement() => new SwimMovement();
    }
}
