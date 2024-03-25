namespace FP.Patterns.Factory.Exercice5.Meals
{
    internal class Pizza : IMeal
    {
        public void Cook()
        {
            Console.WriteLine("Kitchen Cook a Pizza");
        }

        public void Prepare()
        {
            Console.WriteLine("Kitchen Prepare a Pizza");
        }

        public void Serve()
        {
            Console.WriteLine("Kitchen Serve a Pizza");
        }
    }
}
