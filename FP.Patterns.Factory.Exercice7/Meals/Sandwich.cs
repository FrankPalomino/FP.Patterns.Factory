namespace FP.Patterns.Factory.Exercice7.Meals
{
    public class Sandwich : IMeal
    {
        public void Cook()
        {
            Console.WriteLine("Kitchen is Cook a Sandwich");
        }

        public void Prepare()
        {
            Console.WriteLine("Kitchen is Prepare a Sandwich");
        }

        public void Serve()
        {
            Console.WriteLine("Kitchen is Serve a Sandwich");
        }
    }
}
