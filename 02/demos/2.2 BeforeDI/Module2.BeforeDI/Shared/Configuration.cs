namespace Module2.BeforeDI.Shared;
public class Configuration
{
    // We will deal with passing in configuration in a better way in a future module
    // For now hardcoding the values is enough to practice with the concepts from this module
    // Since YOUR code did not work, PluralSight mr. I refactored it a bit and copied the source input file over
    // to the correct directory, so It will run even if I would work from another machine.
    // public string SourceCsvPath => @"c:\src-pluralsight\product-input.csv";
    // public string TargetCsvPath => @"c:\src-pluralsight\product-output.csv";
    private const string FileInputName = "product-input.csv"; // File belongs in ./bin/Debug/net8.0 - I also copied it to net6.0 just to make sure.
    private const string FileOutputName = "product-output.csv";

    public string SourceCsvPath => Path.Combine(Directory.GetCurrentDirectory(), FileInputName);
    public string TargetCsvPath => Path.Combine(Directory.GetCurrentDirectory(), FileOutputName);
}