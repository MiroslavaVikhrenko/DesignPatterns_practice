using DesignPattern_FactoryMethod_Strategy_Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_FactoryMethod_Strategy_Observer.DisplayStrategies
{
    public class LogDisplay : INotificationDisplayStrategy
    {
        public void Display(INotification notification)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[LOG] {notification.GetMessage()}");
            Console.ResetColor();
        }
    }
}
