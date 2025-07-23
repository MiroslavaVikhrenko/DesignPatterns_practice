using DesignPattern_Builder_Composite_Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Builder_Composite_Decorator.Decorators
{
    public class InsuredRoute(IRoute route) : RouteDecorator(route)
    {
        public override double CalculateCost() => _route.CalculateCost() + 10;

        public override string Describe() => _route.Describe() + " + Insurance (+10)";
    }
}
