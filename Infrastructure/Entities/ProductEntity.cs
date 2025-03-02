using Core.InputModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities;

public class ProductEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    [Required]
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
