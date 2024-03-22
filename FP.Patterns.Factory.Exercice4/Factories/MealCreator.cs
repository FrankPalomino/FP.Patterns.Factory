using FP.Patterns.Factory.Exercice4.Meals;

namespace FP.Patterns.Factory.Exercice4.Factories
{
    public abstract class MealCreator
    {
        public abstract Meal CreateMeal();
        public void PrepareCookServe()
        {
            Meal meal = CreateMeal();
            meal.Prepare();
            meal.Cook();
            meal.Serve();
        }
    }
}
