using DesignPattern_Command_TemplateMethod_Iterator.Commands;
using DesignPattern_Command_TemplateMethod_Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Command_TemplateMethod_Iterator.Robots
{
    public class WarehouseRobot : Robot
    {
        public WarehouseRobot(string name) : base(name)
        {
        }
        protected override void ExecuteCommand(ICommand command)
        {
            IsBusy = true;
            if (command is RechargeCommand)
            {
                BatteryLevel = 100; // Recharge the battery
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{Name} is recharging.");
                Console.ResetColor();
            } else
            {
                BatteryLevel -= 10;
            }   
            command.Execute();
            IsBusy = false;
        }
    }
}
