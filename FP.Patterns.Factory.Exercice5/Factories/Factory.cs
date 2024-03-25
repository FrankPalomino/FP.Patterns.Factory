using FP.Patterns.Factory.Exercice5.Meals;

namespace FP.Patterns.Factory.Exercice5.Factories
{
    public abstract class Factory
    {
        public abstract IMeal CreateMeal();

        public IMeal PrepareMeal()
        {
            IMeal meal = CreateMeal();
            meal.Prepare();
            meal.Cook();
            meal.Serve();

            return meal;
        }
    }
}
