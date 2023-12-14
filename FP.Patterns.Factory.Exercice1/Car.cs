namespace FP.Patterns.Facthory.Exercice1
{
    internal class Car : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public string GetDetails()
        {
            return string.Format("CAR → Brand: {0}; Model: {1}; Year: {2}", Brand, Model, Year);
        }
    }
}
