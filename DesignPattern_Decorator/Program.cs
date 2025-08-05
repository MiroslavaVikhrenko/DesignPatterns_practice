using DesignPattern_Decorator.Decorator;

namespace DesignPattern_Decorator
{
    /*
     Создайте систему для заказа кофе, в которой можно добавлять различные добавки к базовому напитку 
    (например: молоко, сахар, сироп и т.д.). Каждая добавка должна декорировать базовый напиток, 
    изменяя его описание и цену.

Требования:

1) Базовый интерфейс ICoffee с методом GetCost() и GetDescription().
2) Классы напитков: Espresso, Americano и т.д.
3) Декораторы: MilkDecorator, SugarDecorator, VanillaDecorator и т.п.
4) Возможность комбинирования добавок произвольно: 

ICoffee coffee = new MilkDecorator(new SugarDecorator(new Espresso()));
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            ICoffee coffee = new CinamonDecorator(new MilkDecorator(new SugarDecorator(new VanillaDecorator(new Espresso()))));

            Console.WriteLine($"Description: {coffee.GetDescription()}");
            Console.WriteLine($"Cost: {coffee.GetCost():C2}");
        }
    }
}
