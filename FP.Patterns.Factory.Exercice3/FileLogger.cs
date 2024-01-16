namespace FP.Patterns.Factory.Exercice3
{
    public class FileLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"File log: {message}");
        }
    }
}
