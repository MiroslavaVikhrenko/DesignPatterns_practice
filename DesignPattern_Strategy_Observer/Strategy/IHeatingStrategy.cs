using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Strategy_Observer.Strategy
{
    public interface IHeatingStrategy
    {
        string Name { get; }
        double Heat(double temperature, double area);
    }
}
