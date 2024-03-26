using FP.Patterns.Factory.Exercice6.Meals;

namespace FP.Patterns.Factory.Exercice6.Factories
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
