namespace FP.Patterns.Factory.Exercice3
{
    public class DatabaseLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"Database log: {message}");
        }
    }
}
