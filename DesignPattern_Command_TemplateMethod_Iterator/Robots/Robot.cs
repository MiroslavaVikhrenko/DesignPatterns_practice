using DesignPattern_Command_TemplateMethod_Iterator.Interfaces;
using DesignPattern_Command_TemplateMethod_Iterator.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Command_TemplateMethod_Iterator.Robots
{
    public abstract class Robot(string name)
    {
        protected string Name = name;
        protected bool IsBusy = false;
        protected int BatteryLevel = 100;

        private Queue<ICommand> _taskQueue = new();

        // Template Method
        public void PerformTasks()
        {
            var iterator = new TaskQueueIterator(_taskQueue);

            while (iterator.HasNext())
            {
                var command = iterator.Next();
                if (CheckStatus())
                {
                    ExecuteCommand(command);
                    Log(command);
                }
            }
        }

        protected virtual bool CheckStatus()
        {
            if (IsBusy)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Name} is busy.");
                Console.ResetColor();
                return false;
            }
            if (BatteryLevel <= 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Name} has low battery: {BatteryLevel}.");
                Console.ResetColor();
                return false;
            }
            return true;
        }

        protected abstract void ExecuteCommand(ICommand command);
        protected virtual void Log(ICommand command)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Name} executed command: {command.GetType().Name}");
            Console.ResetColor();
        }

        public void AddTask(ICommand command)
        {
            _taskQueue.Enqueue(command);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{Name} added task: {command.GetType().Name}");
            Console.ResetColor();
        }
    }
}
