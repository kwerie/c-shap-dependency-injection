using System.Text;

namespace ProductImporter.Shared;

public class ImportStatistics : IImportStatistics
{
    private int _productsImportedCount;
    private int _productsOutputtedCount;

    public void IncrementImportCount()
    {
        _productsImportedCount++;
    }

    public void IncrementOutputCount()
    {
        _productsOutputtedCount++;
    }

    public string GetStatistics()
    {
        // Could be done with just one single line of code, but added the StringBuilder just for the course's sake
        var sb = new StringBuilder();
        sb.Append($"Read a total of {_productsImportedCount} products from source");
        sb.AppendLine();
        sb.Append($"Written a total of {_productsOutputtedCount} products to target");
        return sb.ToString();
    }
}