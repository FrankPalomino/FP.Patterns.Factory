namespace FP.Patterns.Factory.Exercice3
{
    public class FileLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new FileLogger();
        }
    }
}
