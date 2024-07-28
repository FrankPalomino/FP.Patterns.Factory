namespace FP.Patterns.Factory.Exercice8
{
    public class ConsoleLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Loggin to Console");
        }
    }
}
