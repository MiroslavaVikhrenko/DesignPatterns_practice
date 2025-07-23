using DesignPattern_Builder_Composite_Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Builder_Composite_Decorator.Core
{
    // Composite pattern
    public class CompositeRoute : IRoute
    {
        private readonly List<IRoute> _routes = [];

        public void AddRoute(IRoute route) => _routes.Add(route);

        public double CalculateCost() => _routes.Sum(r => r.CalculateCost());

        public string Describe()
        {
            return string.Join("\n", _routes.Select(r => r.Describe())) +
                   $"\nTotal composite cost: {CalculateCost()}";
        }
    }
}
