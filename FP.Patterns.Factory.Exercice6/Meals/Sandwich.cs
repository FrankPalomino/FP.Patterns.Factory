namespace FP.Patterns.Factory.Exercice6.Meals
{
    public class Sandwich : IMeal
    {
        public void Cook()
        {
            Console.WriteLine("Kitchen is Cook the Sandwich");
        }
        public void Prepare()
        {
            Console.WriteLine("Kitchen is Prepare the Sandwich");
        }
        public void Serve()
        {
            Console.WriteLine("Kitchen is Serve the Sandwich");
        }
    }
}
