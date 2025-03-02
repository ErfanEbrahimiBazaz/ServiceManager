namespace Core.Dtos.ProductAggregate
{
    public class CategoryDto
    {
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string? Description { get; set; }
        public virtual List<ProductDto> Products { get; set; } = new();
    }
}
