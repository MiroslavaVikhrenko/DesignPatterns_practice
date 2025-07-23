using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Builder_Composite_Decorator.Interfaces
{
    public interface IRoute
    {
        double CalculateCost();
        string Describe();
    }
}
