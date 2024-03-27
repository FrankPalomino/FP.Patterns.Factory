namespace FP.Patterns.Factory.Exercice7.Meals
{
    public class Burger : IMeal
    {
        public void Cook()
        {
            Console.WriteLine("Kitchen is Cook a Burger");
        }

        public void Prepare()
        {
            Console.WriteLine("Kitchen is Prepare a Burger");
        }

        public void Serve()
        {
            Console.WriteLine("Kitchen is Serve a Burger");
        }
    }
}
