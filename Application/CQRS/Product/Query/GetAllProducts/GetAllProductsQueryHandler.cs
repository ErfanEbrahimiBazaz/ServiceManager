using AutoMapper;
using Infrastructure.Repositories;
using MediatR;
using Application.Mappers;

namespace Application.CQRS.Product.Query.GetAllProducts
{
    public class GetAllProductsQueryHandler(ProductAggregateRepository productRepository,
                                            IMapper mapper) : IRequestHandler<GetAllProductsQuery, List<GetAllProductsQueryResponse>>
    {
        public async Task<List<GetAllProductsQueryResponse>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var result = await productRepository.GetProductsAsync();
            var resultSet = new List<GetAllProductsQueryResponse>();
            foreach(var product in result)
            {
                resultSet.Add(product.ToGetAllProductsQueryResponse());
            }
            //var productsQuery = mapper.Map<List<GetAllProductsQueryResponse>>(result);
            return resultSet;
        }
    }
}
