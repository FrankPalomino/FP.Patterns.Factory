namespace FP.Patters.Factory
{
    public class Factory
    {
        public const int ProductA1 = 1;
        public const int ProductA2 = 2;

        public static ProductT CreateProduct(int type)
        {
            switch (type)
            {
                case ProductA1:
                    return new ProductA1();
                case ProductA2:
                    return new ProductA2();
                default:
                    return null;
            }
        }
    }
}
