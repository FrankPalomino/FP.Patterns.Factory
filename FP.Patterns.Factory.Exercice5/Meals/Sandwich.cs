namespace FP.Patterns.Factory.Exercice5.Meals
{
    internal class Sandwich : IMeal
    {
        public void Cook()
        {
            Console.WriteLine("Kitchen Cook a Sandwich");
        }
        public void Prepare()
        {
            Console.WriteLine("Kitchen Prepare a Sandwich");
        }
        public void Serve()
        {
            Console.WriteLine("Kitchen Serve a Sandwich");
        }
    }
}
