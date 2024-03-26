namespace FP.Patterns.Factory.Exercice6.Meals
{
    public class Burger : IMeal
    {
        public void Cook()
        {
            Console.WriteLine("Kitchen is Cook the Burger");
        }

        public void Prepare()
        {
            Console.WriteLine("Kitchen is Prepare the Burger");
        }

        public void Serve()
        {
            Console.WriteLine("Kitchen is Serve the Burger");
        }
    }
}
