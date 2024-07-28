namespace FP.Patterns.Factory.Exercice8
{
    public class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Loggin to file");
        }
    }
}
