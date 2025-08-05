namespace DesignPattern_Adapter
{
    internal class Program
    {
        /*
         У вас есть устаревший компонент логирования (OldLogger), у которого метод выглядит так:

void WriteLog(string message);

Но ваша система работает с интерфейсом:

interface INewLogger
{
    void LogInfo(string message);
    void LogError(string message);
}

Реализуйте адаптер OldLoggerAdapter, который позволит использовать 
        OldLogger в новой системе. Интерфейс INewLogger должен использоваться в бизнес-классе:

class ReportGenerator
{
    private readonly INewLogger _logger;
    public void GenerateReport() { ... _logger.LogInfo("Report created"); }
}

По итогу задачи, вы должны иметь возможность передать OldLoggerAdapter в ReportGenerator, 
        и старый логгер должен использоваться в новой системе без изменений кода OldLogger.
         */
        static void Main(string[] args)
        {
            OldLogger oldLogger = new OldLogger();
            INewLogger logger = new OldLoggerAdapter(oldLogger);

            ReportGenerator reportGenerator = new ReportGenerator(logger);

            reportGenerator.GenerateReport();
        }
    }
}
