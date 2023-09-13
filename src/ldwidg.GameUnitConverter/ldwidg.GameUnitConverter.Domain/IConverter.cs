namespace ldwidg.GameUnitConverter.Domain;

public interface IConverter
{
    ConvertationResult Convert(SourceItem requestItem, params string[] valueTypes);
}