using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Strategy_Observer.Strategy
{
    public class ElectricHeating : IHeatingStrategy
    {
        public string Name => "Electric Heating";

        public double Heat(double temperature, double area)
        {
            Console.WriteLine("Using Electric Heating Strategy");
            return 0.8 * area * (20 - temperature);
        }
    }
}
