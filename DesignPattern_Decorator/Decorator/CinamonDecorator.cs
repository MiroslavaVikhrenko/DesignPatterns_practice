using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Decorator.Decorator
{
    public class CinamonDecorator : CoffeeDecorator
    {
        public CinamonDecorator(ICoffee coffee) : base(coffee)
        {
        }
        public override double GetCost()
        {
            return _coffee.GetCost() + 0.60; 
        }
        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", with cinnamon";
        }
    }
}
