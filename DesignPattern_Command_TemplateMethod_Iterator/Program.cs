using DesignPattern_Command_TemplateMethod_Iterator.Commands;
using DesignPattern_Command_TemplateMethod_Iterator.Robots;

namespace DesignPattern_Command_TemplateMethod_Iterator
{
    /*
     Вы разрабатываете систему управления заданиями для группы роботов-исполнителей на складе.

1) Каждое задание (Command) — это действие, которое должен выполнить робот:

Переместить коробку 
Сканировать товар 
Зарядиться

2) У каждого робота есть шаблон выполнения задания (Template Method):

Проверка состояния (заряд, занятость)
Выполнение команды
Логгирование результата

3) У каждого робота — очередь заданий (Iterator). 
    Создайте итератор для перебора этих заданий (TaskQueueIterator), не раскрывая внутреннюю структуру очереди.

Требования:


1) Продемонстрировать взаимодействие между командами, шаблоном выполнения и итерацией по задачам;
2) Отделить исполнителя (робота) от логики команд;
3) Позволить легко добавлять новые типы роботов и команд.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            var robot1 = new WarehouseRobot("Robot1");

            robot1.AddTask(new MoveBoxCommand());
            robot1.AddTask(new ScanItemCommand());
            robot1.AddTask(new RechargeCommand());

            robot1.PerformTasks();

            Console.WriteLine("\n------------------\nAll tasks completed.");
        }
    }
}
