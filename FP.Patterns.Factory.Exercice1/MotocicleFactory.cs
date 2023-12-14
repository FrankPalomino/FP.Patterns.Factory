namespace FP.Patterns.Facthory.Exercice1
{
    internal class MotocicleFactory : IFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Motocicle();
        }
    }
}
