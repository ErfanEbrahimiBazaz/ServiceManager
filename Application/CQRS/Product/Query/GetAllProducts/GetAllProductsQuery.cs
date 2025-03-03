using MediatR;

namespace Application.CQRS.Product.Query.GetAllProducts;

public class GetAllProductsQuery : IRequest<List<GetAllProductsQueryResponse>>
{
}
