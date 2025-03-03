using Core.InputModels;

namespace Application.CQRS.Product.Query.GetAllProducts;

public class GetAllProductsQueryResponse
{
    public Guid Id { get; set; }
    public string ProductName { get; set; }
    public long UnitPrice { get; set; }
    public ProductUnits ProductUnit { get; set; }
    public string? Description { get; set; }
    public Guid CategoryId { get; set; }
}
