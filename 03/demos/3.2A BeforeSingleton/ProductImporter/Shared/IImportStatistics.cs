namespace ProductImporter.Shared;

public interface IImportStatistics
{
    void IncrementImportCount();
    void IncrementOutputCount();
    string GetStatistics();
}