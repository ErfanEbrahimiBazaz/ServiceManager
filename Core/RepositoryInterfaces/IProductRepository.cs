using Core.Dtos.ProductAggregate;
using Core.InputModels;

namespace Core.RepositoryInterfaces
{
    public interface IProductRepository
    {
        public Task<IEnumerable<ProductDto>> GetProductsAsync();
        public Task<ProductDto> GetProductById(Guid productId);
        public Task<Guid> CreateProduct(ProductCreateDto product);
        public void UpdateProduct(ProductCreateDto product);
        public Task SaveChangesAysnc();
    }
}
