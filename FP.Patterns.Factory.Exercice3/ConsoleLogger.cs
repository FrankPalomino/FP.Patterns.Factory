namespace FP.Patterns.Factory.Exercice3
{
    public class ConsoleLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"Console log: {message}");
        }
    }
}
