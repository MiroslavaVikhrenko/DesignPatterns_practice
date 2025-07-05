using DesignPattern_Strategy_Observer.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Strategy_Observer.Observer
{
    public class HeatingSystem : IObserver
    {
        private IHeatingStrategy _heatingStrategy;

        public HeatingSystem(IHeatingStrategy heatingStrategy)
        {
            _heatingStrategy = heatingStrategy;
        }

        public void Update(double temperature, double area)
        {
            double energyConsumed = _heatingStrategy.Heat(temperature, area);
        }
        public string GetHeatingStrategyName()
        {
            return _heatingStrategy.Name;
        }
        public void SetHeatingStrategy(IHeatingStrategy heatingStrategy)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Changing heating strategy...");
            Console.ResetColor();
            _heatingStrategy = heatingStrategy;
        }
    }
}
