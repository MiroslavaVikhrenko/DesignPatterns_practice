using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Strategy_Observer.Observer
{
    public class TemperatureSensor
    {
        private List<IObserver> _observers = new List<IObserver>();
        private double _temperatureThreshold;
        public TemperatureSensor(double temperatureThreshold)
        {
            _temperatureThreshold = temperatureThreshold;
        }
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyObservers(double newTemperature, double area)
        {
            if (newTemperature < _temperatureThreshold)
            {
                Console.WriteLine($"Temperature is below threshold: {newTemperature} < {_temperatureThreshold}. Notifying observers...");
                foreach (var observer in _observers)
                {
                    observer.Update(newTemperature, area);
                }
            }
            else
            {
                Console.WriteLine($"Temperature is above threshold: {newTemperature} >= {_temperatureThreshold}. No action taken.");
            }
        }
    }
}
