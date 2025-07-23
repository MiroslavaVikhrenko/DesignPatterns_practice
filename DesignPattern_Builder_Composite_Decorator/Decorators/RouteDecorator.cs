using DesignPattern_Builder_Composite_Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Builder_Composite_Decorator.Decorators
{
    public abstract class RouteDecorator : IRoute
    {
        protected readonly IRoute _route;

        protected RouteDecorator(IRoute route)
        {
            _route = route;
        }

        public abstract double CalculateCost();
        public abstract string Describe();
    }
}
