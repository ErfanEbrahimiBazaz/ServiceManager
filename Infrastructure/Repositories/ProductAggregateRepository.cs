using AutoMapper;
using Core.Dtos.ProductAggregate;
using Core.InputModels;
using Core.RepositoryInterfaces;
using Infrastructure.DbContexts;
using Infrastructure.Entities;
using Infrastructure.Mappers;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class ProductAggregateRepository(ProductAggregateContext dbContext,
                                        IMapper mapper) : IProductRepository
{
    public async Task<Guid> CreateProduct(ProductCreateDto productDto)
    {
        // validation on product
        var product = new ProductEntity
        {
            ProductName = productDto.ProductName,
            UnitPrice = productDto.UnitPrice,
            ProductUnit = productDto.ProductUnit,
            Description = productDto.Description,
            CategoryId = productDto.CategoryId,
        };
        await dbContext.Products.AddAsync(product);
        return product.Id;
    }

    public async Task<ProductDto> GetProductById(Guid productId)
    {
        ProductEntity product = await dbContext.Products.SingleOrDefaultAsync( p => p.Id == productId);
        var productDto = mapper.Map<ProductDto>(product);
        return productDto;
    }

    public async Task<IEnumerable<ProductDto>> GetProducts()
    {
        List<ProductEntity> result = await dbContext.Products.ToListAsync();
        return mapper.Map<List<ProductDto>>(result);
    }

    public async Task SaveChangesAysnc()
    {
        await dbContext.SaveChangesAsync();
    }

    public void UpdateProduct(ProductCreateDto product)
    {
        throw new NotImplementedException();
    }
}
