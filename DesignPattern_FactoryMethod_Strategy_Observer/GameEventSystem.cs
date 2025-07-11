using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_FactoryMethod_Strategy_Observer
{
    // OBSERVER
    public class GameEventSystem
    {
        public delegate void GameEventHandler(GameEventType eventType, object data);
        public event GameEventHandler? OnGameEvent;

        public void TriggerEvent(GameEventType eventType, object data)
        {
            OnGameEvent?.Invoke(eventType, data);
        }
    }
}
