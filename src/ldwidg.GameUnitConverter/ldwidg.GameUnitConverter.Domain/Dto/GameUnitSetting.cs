using System.Text.Json.Serialization;

namespace ldwidg.GameUnitConverter.Domain;

public class GameUnitSetting
{
    [JsonPropertyName("gameName")]
    public string GameName { get; set; }
    [JsonPropertyName("mm")]
    public float? Millimeter { get; set; }
    [JsonPropertyName("m")]
    public float? Meter { get; set; }
    [JsonPropertyName("unit")]
    public float? Unit { get; set; }
    [JsonPropertyName("feet")]
    public float? Feet { get; set; }
    [JsonPropertyName("cm")]
    public float? Cm { get; set; }
    [JsonPropertyName("inches")]
    public float? Inches {get; set; }
}