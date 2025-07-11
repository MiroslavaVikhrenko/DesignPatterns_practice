using DesignPattern_FactoryMethod_Strategy_Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_FactoryMethod_Strategy_Observer.Notifications
{
    public class LevelUpNotification : INotification
    {
        public int NewLevel { get; }

        public LevelUpNotification(int newLevel)
        {
            NewLevel = newLevel;
        }

        public string GetMessage() => $"You reached level {NewLevel}";
    }
}
