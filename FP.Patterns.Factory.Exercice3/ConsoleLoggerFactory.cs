namespace FP.Patterns.Factory.Exercice3
{
    public class ConsoleLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new ConsoleLogger();
        }
    }
}
