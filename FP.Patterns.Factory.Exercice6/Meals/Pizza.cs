namespace FP.Patterns.Factory.Exercice6.Meals
{
    internal class Pizza : IMeal
    {
        public void Cook()
        {
            Console.WriteLine("Kitchen is Cook the Pizza");
        }

        public void Prepare()
        {
            Console.WriteLine("Kitchen is Prepare the Pizza");
        }

        public void Serve()
        {
            Console.WriteLine("Kitchen is Serve the Pizza");
        }
    }
}
