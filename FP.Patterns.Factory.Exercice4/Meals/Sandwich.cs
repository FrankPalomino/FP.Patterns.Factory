namespace FP.Patterns.Factory.Exercice4.Meals
{
    public class Sandwich : Meal
    {
        public override void Cook()
        {
            Console.WriteLine("Specific Cook for Sandwich...");
        }

        public override void Prepare()
        {
            Console.WriteLine("Specific Prepare for Sandwich...");
        }

        public override void Serve()
        {
            Console.WriteLine("Specific Serve for Sandwich...");
        }
    }
}
