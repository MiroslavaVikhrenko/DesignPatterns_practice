using DesignPattern_FactoryMethod_Strategy_Observer.Interfaces;
using DesignPattern_FactoryMethod_Strategy_Observer.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_FactoryMethod_Strategy_Observer
{
    // FACTORY METHOD
    public class NotificationFactory
    {
        public static INotification CreateNotification(GameEventType eventType, object data)
        {
            INotification notification;

            switch (eventType)
            {
                case GameEventType.ItemReceived:
                    // Convert data to string for item name
                    notification = new ItemNotification(data.ToString());
                    break;

                case GameEventType.LevelUp:
                    // Convert data to int for level number
                    notification = new LevelUpNotification((int)data);
                    break;

                default:
                    throw new ArgumentException("Unknown event type");
            }

            return notification;
        }
    }

    public enum GameEventType
    {
        ItemReceived,
        LevelUp
    }
}
