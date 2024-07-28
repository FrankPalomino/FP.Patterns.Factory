namespace FP.Patterns.Factory.Exercice8
{
    public class ConsoleLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new ConsoleLogger();
        }
    }
}
