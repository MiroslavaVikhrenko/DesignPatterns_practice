using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Decorator
{
    public class Americano : ICoffee
    {
        public double GetCost()
        {
            return 3.00;
        }

        public string GetDescription()
        {
            return "Americano";
        }
    }
}
