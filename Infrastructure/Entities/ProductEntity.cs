using Core.InputModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Infrastructure.Entities;

public class ProductEntity
{
    public ProductEntity()
    {
        
    }
    
    public ProductEntity(Guid id, string productName, long unitPrice, ProductUnits productUnit, string? description, Guid categoryId)
    {
        Id = id;
        ProductName = productName;
        UnitPrice = unitPrice;
        ProductUnit = productUnit;
        Description = description;
        CategoryId = categoryId;
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string ProductName { get; set; }
    [Required]
    public long UnitPrice { get; set; }
    [Required]
    public ProductUnits ProductUnit { get; set; }
    [MaxLength(300)]
    public string? Description { get; set; }

    [Required]
    [ForeignKey(nameof(CategoryId))]
    public Guid CategoryId { get; set; }
    public virtual CategoryEntity Category { get; set; }
}
