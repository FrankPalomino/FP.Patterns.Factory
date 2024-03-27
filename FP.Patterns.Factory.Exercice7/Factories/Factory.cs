using FP.Patterns.Factory.Exercice7.Meals;

namespace FP.Patterns.Factory.Exercice7.Factories
{
    public abstract class Factory
    {
        public abstract IMeal CreateMeal();

        public void PrepareMeal()
        {
            IMeal meal = CreateMeal();
            meal.Prepare();
            meal.Cook();
            meal.Serve();
        }
    }
}
