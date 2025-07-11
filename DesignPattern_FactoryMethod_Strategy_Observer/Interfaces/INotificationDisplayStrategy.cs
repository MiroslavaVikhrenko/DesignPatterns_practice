using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_FactoryMethod_Strategy_Observer.Interfaces
{
    // STRATEGY
    public interface INotificationDisplayStrategy
    {
        void Display(INotification notification);
    }
}
