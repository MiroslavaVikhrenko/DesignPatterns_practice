using DesignPattern_FactoryMethod_Strategy_Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_FactoryMethod_Strategy_Observer.DisplayStrategies
{
    public class SoundDisplay : INotificationDisplayStrategy
    {
        public void Display(INotification notification)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"[SOUND] {notification.GetMessage()}");
            Console.ResetColor();
        }
    }
}
