using Module2.BeforeDI;
using Module2.BeforeDI.Shared;
using Module2.BeforeDI.Source;
using Module2.BeforeDI.Target;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

internal class Program
{
    public static int Main(string[] args)
    {
        using var host = Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                services.AddTransient<Configuration>();
                services.AddTransient<IPriceParser, PriceParser>();
                services.AddTransient<IProductSource, ProductSource>();
                
                services.AddTransient<IProductFormatter, ProductFormatter>();
                services.AddTransient<IProductTarget, ProductTarget>();

                services.AddSingleton<ProductImporter>();
            })
            .Build();
        var productImporter = host.Services.GetRequiredService<ProductImporter>();
        productImporter.Run();
        return 0;
    }
}