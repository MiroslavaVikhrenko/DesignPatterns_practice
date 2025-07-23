using DesignPattern_Builder_Composite_Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Builder_Composite_Decorator.Core
{
    public class SingleRoute : IRoute
    {
        public string From { get; }
        public string To { get; }
        public string TransportType { get; }
        public double BaseCost { get; }

        public SingleRoute(string from, string to, string transportType, double baseCost)
        {
            From = from;
            To = to;
            TransportType = transportType;
            BaseCost = baseCost;
        }

        public double CalculateCost() => BaseCost;

        public string Describe()
            => $"{TransportType} route from {From} to {To} costs {BaseCost}";
    }
}
