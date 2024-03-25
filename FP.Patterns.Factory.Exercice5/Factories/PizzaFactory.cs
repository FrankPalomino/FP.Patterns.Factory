using FP.Patterns.Factory.Exercice5.Meals;

namespace FP.Patterns.Factory.Exercice5.Factories
{
    public class PizzaFactory : Factory
    {
        public override IMeal CreateMeal()
        {
            return new Pizza();
        }
    }
}
