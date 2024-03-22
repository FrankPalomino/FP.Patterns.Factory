using FP.Patterns.Factory.Exercice4.Meals;

namespace FP.Patterns.Factory.Exercice4.Factories
{
    public class BurgerCreator : MealCreator
    {
        public override Meal CreateMeal()
        {
            return new Burger();
        }
    }
}
