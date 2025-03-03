using AutoMapper;
using Infrastructure.Repositories;
using MediatR;

namespace Application.CQRS.Product.Query.GetAllProducts
{
    public class GetAllProductsQueryHandler(ProductAggregateRepository productRepository,
                                            IMapper mapper) : IRequestHandler<GetAllProductsQuery, List<GetAllProductsQueryResponse>>
    {
        public async Task<List<GetAllProductsQueryResponse>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var result = await productRepository.GetProductsAsync();
            var productsQuery = mapper.Map<List<GetAllProductsQueryResponse>>(result);
            return productsQuery;
        }
    }
}
