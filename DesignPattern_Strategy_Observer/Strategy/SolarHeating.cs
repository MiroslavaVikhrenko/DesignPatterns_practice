using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Strategy_Observer.Strategy
{
    public class SolarHeating : IHeatingStrategy
    {
        public string Name => "Solar Heating";

        public double Heat(double temperature, double area)
        {
            Console.WriteLine("Using Solar Heating Strategy");
            return 0.3 * area * (20 - temperature);
        }
    }
}
