namespace FP.Patterns.Factory.Exercice2
{
    public class ShapeFactory
    {
        public IShape GetShape(string type)
        {
            switch (type)
            {
                case "0":
                    return new Circle();
                case "1":
                    return new Rectangle();
                case "2":
                    return new Triangle();
                default:
                    return null;
            }
        }
    }
}
