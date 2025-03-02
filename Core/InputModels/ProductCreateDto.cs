namespace Core.InputModels;

public class ProductCreateDto
{
    public string ProductName { get; set; }
    public long UnitPrice { get; set; }
    public ProductUnits ProductUnit { get; set; }
    public string? Description { get; set; }
}
