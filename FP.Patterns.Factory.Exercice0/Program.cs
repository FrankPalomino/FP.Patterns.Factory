using FP.Patters.Factory;

var productTypeList = new List<int> { Factory.ProductA1, Factory.ProductA2 };

var result = new List<ProductT>();

foreach (var productType in productTypeList)
{
    result.Add(Factory.CreateProduct(productType));
}

foreach (var product in result)
{
    Console.WriteLine(product.Es());
}

Console.ReadKey();