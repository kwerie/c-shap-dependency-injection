using Module2.BeforeDI;
using Module2.BeforeDI.Shared;
using Module2.BeforeDI.Source;
using Module2.BeforeDI.Target;

internal class Program
{
    public static int Main()
    {
        var configuration = new Configuration();
        var priceParser = new PriceParser();
        var productSource = new ProductSource(
            configuration,
            priceParser
        );
        var productFormatter = new ProductFormatter();
        var productTarget = new ProductTarget(
            configuration,
            productFormatter
        );
        var productImporter = new ProductImporter(productSource, productTarget);
        productImporter.Run();
        return 0;
    }
}