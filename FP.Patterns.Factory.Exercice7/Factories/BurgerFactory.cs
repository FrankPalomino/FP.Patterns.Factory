using FP.Patterns.Factory.Exercice7.Meals;

namespace FP.Patterns.Factory.Exercice7.Factories
{
    public class BurgerFactory : Factory
    {
        public override IMeal CreateMeal()
        {
            return new Burger();
        }
    }
}
