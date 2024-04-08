namespace ProductImporter.Shared;
public class Configuration
{
    // Refactored this again so the code will actually run properly
    private const string FileInputName = "input-product.csv"; // File belongs in ./bin/Debug/net8.0 - I also copied it to net6.0 just to make sure.
    private const string FileOutputName = "output-product.csv";

    public string SourceCsvPath => Path.Combine(Directory.GetCurrentDirectory(), FileInputName);
    public string TargetCsvPath => Path.Combine(Directory.GetCurrentDirectory(), FileOutputName);
}