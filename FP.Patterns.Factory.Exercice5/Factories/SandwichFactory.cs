using FP.Patterns.Factory.Exercice5.Meals;

namespace FP.Patterns.Factory.Exercice5.Factories
{
    public class SandwichFactory : Factory
    {
        public override IMeal CreateMeal()
        {
            return new Sandwich();
        }
    }
}
