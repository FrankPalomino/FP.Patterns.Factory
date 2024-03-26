using FP.Patterns.Factory.Exercice6.Meals;

namespace FP.Patterns.Factory.Exercice6.Factories
{
    public class SandwichFactory : Factory
    {
        public override IMeal CreateMeal()
        {
            return new Sandwich();
        }
    }
}
