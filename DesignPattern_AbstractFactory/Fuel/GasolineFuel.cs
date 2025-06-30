using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_AbstractFactory.Fuel
{
    public class GasolineFuel : IFuel
    {
        public string GetFuelType() => "Gasoline";
    }
}
