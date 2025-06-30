using DesignPattern_AbstractFactory.Fuel;
using DesignPattern_AbstractFactory.Movement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_AbstractFactory.CarFactory
{
    public interface ICarFactory
    {
        IFuel CreateFuel();
        IMovement CreateMovement();
    }
}
