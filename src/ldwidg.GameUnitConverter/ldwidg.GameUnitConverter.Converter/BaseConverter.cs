using ldwidg.GameUnitConverter.Domain;

namespace ldwidg.GameUnitConverter.Converter;

public class BaseConverter : IConverter
{
    private readonly IConverterSettings _converterSettings;
    public BaseConverter(IConverterSettings converterSettings)
    {
        _converterSettings = converterSettings;
    }
    public ConvertationResult Convert(SourceItem requestItem, params string[] valueTypes)
    {
        throw new NotImplementedException();
    }
}