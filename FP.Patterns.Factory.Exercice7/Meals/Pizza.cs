namespace FP.Patterns.Factory.Exercice7.Meals
{
    public class Pizza : IMeal
    {
        public void Cook()
        {
            Console.WriteLine("Kitchen is Cook a Pizza");
        }

        public void Prepare()
        {
            Console.WriteLine("Kitchen is Prepare a Pizza");
        }

        public void Serve()
        {
            Console.WriteLine("Kitchen is Serve a Pizza");
        }
    }
}
