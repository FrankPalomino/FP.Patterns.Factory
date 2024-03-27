using FP.Patterns.Factory.Exercice7.Meals;

namespace FP.Patterns.Factory.Exercice7.Factories
{
    public class SandwichFactory : Factory
    {
        public override IMeal CreateMeal()
        {
            return new Sandwich();
        }
    }
}
