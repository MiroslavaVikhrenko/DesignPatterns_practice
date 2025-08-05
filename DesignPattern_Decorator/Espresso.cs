using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Decorator
{
    public class Espresso : ICoffee
    {
        public double GetCost()
        {
            return 2.50;
        }

        public string GetDescription()
        {
            return "Espresso";
        }
    }
}
