using FP.Patterns.Factory.Exercice4.Meals;

namespace FP.Patterns.Factory.Exercice4.Factories
{
    public class SandwichCreator : MealCreator
    {
        public override Meal CreateMeal()
        {
            return new Sandwich();
        }
    }
}
