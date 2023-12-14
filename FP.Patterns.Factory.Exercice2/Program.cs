using FP.Patterns.Factory.Exercice2;

Console.WriteLine("Draw a: 0-Circle, 1-Rectangle, 2-Triangle");

var type = Console.ReadLine();

if (type is not null)
{
    ShapeFactory shapeFactory = new ShapeFactory();

    var shape = shapeFactory.GetShape(type);

    Console.WriteLine(shape.Draw());
}