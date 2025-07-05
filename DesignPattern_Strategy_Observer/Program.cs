using DesignPattern_Strategy_Observer.Observer;
using DesignPattern_Strategy_Observer.Strategy;

namespace DesignPattern_Strategy_Observer
{
    internal class Program
    {
        /*
         Вам необходимо реализовать систему «Умного дома», в которой:

1) Разные типы отопления (Стратегия) могут использоваться для обогрева помещения:

Газовое отопление
Электрическое отопление
Солнечное отопление

Каждый тип реализует свой способ расчета потребления энергии в зависимости от температуры и площади.

2) Датчики температуры (Наблюдатель) следят за температурой в комнате. Когда температура падает ниже 
        определенного уровня, они уведомляют систему обогрева, которая должна включить отопление с выбранной стратегией. 

Требования:

1) Создайте интерфейс IHeatingStrategy с методом Heat(double temperature, double area), который возвращает, 
        сколько энергии будет потреблено.
2) Создайте несколько реализаций этого интерфейса: GasHeating, ElectricHeating, SolarHeating.
3) Создайте класс TemperatureSensor, который реализует паттерн Наблюдатель — он уведомляет подписчиков (например, 
        систему обогрева), когда температура падает ниже заданного порога.
4) Класс HeatingSystem подписывается на TemperatureSensor и при получении уведомления запускает метод Heat(...) с
        текущей стратегией.
         */
        static void Main(string[] args)
        {
            TemperatureSensor sensor = new TemperatureSensor(20.0);
            HeatingSystem heatingSystem = new HeatingSystem(new GasHeating());

            sensor.AddObserver(heatingSystem);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose heating strategy:");
                Console.WriteLine("1. Gas Heating");
                Console.WriteLine("2. Electric Heating");
                Console.WriteLine("3. Solar Heating");
                Console.WriteLine("4. Exit");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    heatingSystem.SetHeatingStrategy(new GasHeating());
                }
                else if (choice == "2")
                {
                    heatingSystem.SetHeatingStrategy(new ElectricHeating());
                }
                else if (choice == "3")
                {
                    heatingSystem.SetHeatingStrategy(new SolarHeating());
                }
                else if (choice == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again.");
                    continue;
                }
                Console.WriteLine($"Current heating strategy: {heatingSystem.GetHeatingStrategyName()}");

                Console.WriteLine("Enter current temperature:");

                double currentTemperature = Convert.ToDouble(Console.ReadLine());

                sensor.NotifyObservers(currentTemperature, 50.0);
                Console.ReadLine();
            }

            Console.WriteLine("Exiting the program...");
        }
    }
}
