using DesignPattern_AbstractFactory.CarFactory;
using DesignPattern_AbstractFactory.Client;

namespace DesignPattern_AbstractFactory
{
    internal class Program
    {
        /*
         На основе Abstract Factory, реализовать возможность создания автомобилей с разных видом топлива и с 
        разной возможность передвижения.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a car type:");
            Console.WriteLine("1. Gasoline Drive Car");
            Console.WriteLine("2. Electric Fly Car");
            Console.WriteLine("3. Diesel Swim Car");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            ICarFactory factory;

            switch (choice)
            {
                case "1":
                    factory = new GasolineDriveCarFactory();
                    break;
                case "2":
                    factory = new ElectricFlyCarFactory();
                    break;
                case "3":
                    factory = new DieselSwimCarFactory();
                    break;
                default:
                    throw new Exception("Invalid choice");
            }

            Car car = new Car(factory);
            Console.WriteLine(car);
        }
    }
}
