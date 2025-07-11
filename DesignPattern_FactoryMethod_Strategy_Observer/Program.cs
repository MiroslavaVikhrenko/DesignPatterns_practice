using DesignPattern_FactoryMethod_Strategy_Observer.DisplayStrategies;

namespace DesignPattern_FactoryMethod_Strategy_Observer
{
    /*
     Вы разрабатываете систему игровых уведомлений (например, для RPG игры). 
    В зависимости от действия игрока (например, победа в бою, получение предмета, повышение уровня), 
    генерируются уведомления. В зависимости от настроек игрока, уведомления могут отображаться по-разному: 
    как всплывающее окно, лог в чате, либо звуковой сигнал.

Создать расширяемую систему уведомлений с возможностью легко добавлять новые типы уведомлений и способы их отображения.

Требования:

Factory Method - использовать для создания объектов уведомлений в зависимости от типа события.
Strategy - разные стратегии отображения уведомлений: всплывающее окно, запись в лог, воспроизведение звука.
Observer - игровой движок уведомляет систему о событии (например, "игрок получил предмет"), и подписчики 
    получают уведомление.

Примерная структура классов:

-INotification – интерфейс уведомления.
--ItemNotification, LevelUpNotification и т.д. – конкретные уведомления.
-INotificationDisplayStrategy – стратегия отображения (PopupDisplay, LogDisplay, SoundDisplay).
NotificationFactory – фабрика уведомлений.
NotificationManager – реализует Observer и управляет подписчиками.
GameEventSystem – генерирует события (наблюдаемый объект).
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // Observer pattern
            var notificationManager = new NotificationManager();
            var eventSystem = new GameEventSystem();

            // Subscribe display strategies
            notificationManager.Subscribe(new PopupDisplay());
            notificationManager.Subscribe(new LogDisplay());
            notificationManager.Subscribe(new SoundDisplay());

            // Hook game events to notification generation
            eventSystem.OnGameEvent += (type, data) =>
            {
                // Use factory method to create correct notification type (Factory Method pattern)
                var notification = NotificationFactory.CreateNotification(type, data);
                // Notify all registered display strategies (Observer + Strategy patterns)
                notificationManager.Notify(notification);
            };

            // Simulate events
            eventSystem.TriggerEvent(GameEventType.ItemReceived, "Magical item");
            eventSystem.TriggerEvent(GameEventType.LevelUp, 5);

            Console.ReadKey();
        }
    }
}
