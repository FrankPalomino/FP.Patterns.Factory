namespace FP.Patterns.Factory.Exercice5.Meals
{
    public class Burger : IMeal
    {
        public void Cook()
        {
            Console.WriteLine("Kitchen Cook a Burger");
        }

        public void Prepare()
        {
            Console.WriteLine("Kitchen Prepare a Burger");
        }

        public void Serve()
        {
            Console.WriteLine("Kitchen Serve a Burger");
        }
    }
}
