using DesignPattern_Builder_Composite_Decorator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Builder_Composite_Decorator.Builder
{
    // Builder Pattern
    public class RouteBuilder
    {
        private string _from;
        private string _to;
        private string _transport;
        private double _cost;

        public RouteBuilder From(string from)
        {
            _from = from;
            return this;
        }

        public RouteBuilder To(string to)
        {
            _to = to;
            return this;
        }

        public RouteBuilder WithTransport(string transport)
        {
            _transport = transport;
            return this;
        }

        public RouteBuilder WithCost(double cost)
        {
            _cost = cost;
            return this;
        }

        public SingleRoute Build()
        {
            return new SingleRoute(_from, _to, _transport, _cost);
        }
    }
}
