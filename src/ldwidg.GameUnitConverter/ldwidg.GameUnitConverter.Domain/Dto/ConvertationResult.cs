namespace ldwidg.GameUnitConverter.Domain;

public class ConvertationResult
{
    public bool IsSuccess { get; set; }
    
    public List<ConvertationItem>? Measurements {get; set; }
    public string ErrorMessage { get; set; }
}