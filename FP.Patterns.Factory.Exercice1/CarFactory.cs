namespace FP.Patterns.Facthory.Exercice1
{
    internal class CarFactory : IFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Car();
        }
    }
}
