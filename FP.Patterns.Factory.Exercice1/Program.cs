using FP.Patterns.Facthory.Exercice1;

IFactory factory = new MotocicleFactory();

IVehicle vehicle = factory.CreateVehicle();

Console.WriteLine(vehicle.GetDetails());