namespace FP.Patterns.Factory.Exercice3
{
    public class DatabaseLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new DatabaseLogger();
        }
    }
}
