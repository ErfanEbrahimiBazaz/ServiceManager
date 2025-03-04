using Application.CQRS.Product.Query.GetAllProducts;
using Core.Dtos.ProductAggregate;
using Infrastructure.Entities;

namespace Application.Mappers;

//public class ProductProfile : Profile
//{
//    public ProductProfile()
//    {
//        CreateMap<ProductEntity, GetAllProductsQueryResponse>()
//            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
//            .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.ProductName))
//            .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.UnitPrice))
//            .ForMember(dest => dest.ProductUnit, opt => opt.MapFrom(src => src.ProductUnit))
//            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
//            .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId));
//    }
//}

public static class ResponseMapper
{
    public static GetAllProductsQueryResponse ToGetAllProductsQueryResponse(this ProductDto productDto)
    {
        var response = new GetAllProductsQueryResponse
        {
            Id = productDto.Id,
            ProductName = productDto.ProductName,
            UnitPrice = productDto.UnitPrice,
            ProductUnit = productDto.ProductUnit,
            Description = productDto.Description,
            CategoryId = productDto.CategoryId,
        };
        return response;
    }
}