using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DbContexts;

public class ProductAggregateContext : DbContext
{
    public ProductAggregateContext(DbContextOptions<ProductAggregateContext> options) : base(options)
    {
    }

    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }
}
