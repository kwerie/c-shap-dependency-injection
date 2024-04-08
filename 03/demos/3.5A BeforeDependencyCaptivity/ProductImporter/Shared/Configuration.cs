namespace ProductImporter.Shared;
public class Configuration
{
    // We will deal with passing in configuration in a better way in a future module
    // For now hardcoding the values is enough to practice with the concepts from this module

    private const string FileInputName = "input-product.csv"; // File belongs in ./bin/Debug/net8.0 - I also copied it to net6.0 just to make sure.
    private const string FileOutputName = "output-product.csv";

    public string SourceCsvPath => Path.Combine(Directory.GetCurrentDirectory(), FileInputName);
    public string TargetCsvPath => Path.Combine(Directory.GetCurrentDirectory(), FileOutputName);}