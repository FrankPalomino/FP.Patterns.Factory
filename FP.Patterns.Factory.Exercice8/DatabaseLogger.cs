namespace FP.Patterns.Factory.Exercice8
{
    public class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Loggin to Database");
        }
    }
}
