namespace DesignPattern_Singleton
{
    /*
     Вам необходимо реализовать простой логгер, который записывает действия пользователя в текстовый файл. 
    При этом важно, чтобы во всём приложении использовался единственный экземпляр логгера — 
    для этого примените паттерн Singleton.

Требования:

1) Класс Logger должен реализовывать паттерн Singleton: приватный конструктор, 
    статическое поле для хранения единственного экземпляра, публичный метод или свойство для доступа к экземпляру. 
2) Метод Log(string message) записывает переданное сообщение в файл log.txt (в директории рядом с приложением), 
    добавляя текущее время.
3) Создайте тестовый класс Program, который вызывает Logger.Instance.Log(...) из разных мест 
    (например, из разных методов).
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger.GetInstance().Log("Application started.");
            DoTask1();
            DoTask2();
            Logger.GetInstance().Log("Application completed.");
        }

        static void DoTask1()
        {
            Logger.GetInstance().Log("Task 1 done");
        }

        static void DoTask2()
        {
            Logger.GetInstance().Log("Task 2 done");
        }
    }
}
