using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities;

public class CategoryEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string? Description { get; set; }
    public virtual List<ProductEntity> Products { get; set; } = new();
}
