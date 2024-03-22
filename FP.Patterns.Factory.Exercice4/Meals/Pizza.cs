namespace FP.Patterns.Factory.Exercice4.Meals
{
    public class Pizza : Meal
    {
        public override void Cook()
        {
            Console.WriteLine("Specific Cook for Pizza...");
        }

        public override void Prepare()
        {
            Console.WriteLine("Specific Prepare for Pizza...");
        }

        public override void Serve()
        {
            Console.WriteLine("Specific Serve for Pizza...");
        }
    }
}
