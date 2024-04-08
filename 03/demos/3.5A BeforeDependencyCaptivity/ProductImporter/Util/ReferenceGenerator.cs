namespace ProductImporter.Util;

public class ReferenceGenerator : IReferenceGenerator
{
    private readonly IDateTimeProvider _dateTimeProvider;
    private int _counter = -1;

    public ReferenceGenerator(IDateTimeProvider dateTimeProvider)
    {
        _dateTimeProvider = dateTimeProvider;
    }

    public string GetReference()
    {
        _counter++;
        var nowUtc = _dateTimeProvider.GetUtcDateTime();
        return $"{nowUtc:yyyy-MM-ddTHH:mm:ss.FFF}-{_counter:D4}";
    }
}