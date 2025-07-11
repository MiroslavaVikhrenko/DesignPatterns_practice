using DesignPattern_FactoryMethod_Strategy_Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_FactoryMethod_Strategy_Observer
{
    // OBSERVER
    public class NotificationManager
    {
        private readonly List<INotificationDisplayStrategy> _strategies = new();

        public void Subscribe(INotificationDisplayStrategy strategy)
        {
            _strategies.Add(strategy);
        }

        public void Notify(INotification notification)
        {
            foreach (var strategy in _strategies)
            {
                strategy.Display(notification);
            }
        }
    }
}
