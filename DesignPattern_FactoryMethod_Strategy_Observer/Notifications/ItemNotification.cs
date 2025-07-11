using DesignPattern_FactoryMethod_Strategy_Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_FactoryMethod_Strategy_Observer.Notifications
{
    // FACTORY METHOD
    public class ItemNotification : INotification
    {
        public string ItemName { get; }

        public ItemNotification(string itemName)
        {
            ItemName = itemName;
        }

        public string GetMessage() => $"You have received: {ItemName}";
    }
}
