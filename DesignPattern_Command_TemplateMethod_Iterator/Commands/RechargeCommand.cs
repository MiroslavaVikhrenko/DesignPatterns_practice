using DesignPattern_Command_TemplateMethod_Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Command_TemplateMethod_Iterator.Commands
{
    public class RechargeCommand : ICommand
    {
        public string Name => "Recharge";

        public void Execute()
        {
            Console.WriteLine($"Executing {Name} Command");
        }
    }
}
