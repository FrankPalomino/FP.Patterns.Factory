namespace FP.Patterns.Facthory.Exercice1
{
    internal class Motocicle : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public string GetDetails()
        {
            return string.Format("MOTOCICLE → Brand: {0}; Model: {1}; Year: {2}", Brand, Model, Year);
        }
    }
}
