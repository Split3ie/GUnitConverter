using System.Text.Json.Serialization;

namespace ldwidg.GameUnitConverter.ViewModels;

public class ImportGameUnitsViewModel : ViewModelBase
{
    public string GameName { get; set; }
    public float? Millimeter { get; set; }
    public float? Meter { get; set; }
    public float? Unit { get; set; }
    public float? Feet { get; set; }
    public float? Cm { get; set; }
    public float? Inches {get; set; }
}