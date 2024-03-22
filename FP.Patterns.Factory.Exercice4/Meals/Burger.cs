namespace FP.Patterns.Factory.Exercice4.Meals
{
    public class Burger : Meal
    {
        public override void Cook()
        {
            Console.WriteLine("Specific Cook step for Burger");
        }

        public override void Prepare()
        {
            Console.WriteLine("Specific Prepare step for Burger");
        }

        public override void Serve()
        {
            Console.WriteLine("Specific Serve step for Burger");
        }
    }
}
