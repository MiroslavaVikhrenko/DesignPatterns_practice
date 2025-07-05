using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Strategy_Observer.Strategy
{
    public class GasHeating : IHeatingStrategy
    {
        public string Name => "Gas Heating";

        public double Heat(double temperature, double area)
        {
            Console.WriteLine("Using Gas Heating Strategy");
            return 0.5 * area * (20 - temperature);
        }
    }
}
