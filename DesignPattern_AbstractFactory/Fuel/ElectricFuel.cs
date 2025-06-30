using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_AbstractFactory.Fuel
{
    public class ElectricFuel : IFuel
    {
        public string GetFuelType() => "Electric";
    }
}
