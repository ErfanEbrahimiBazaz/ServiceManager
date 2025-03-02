using AutoMapper;
using Core.Dtos.ProductAggregate;
using Infrastructure.Entities;

namespace Infrastructure.Mappers;

public class ProductMapper : Profile
{
    public ProductMapper()
    {
        CreateMap<ProductEntity, ProductDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.ProductName))
            .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.UnitPrice))
            .ForMember(dest => dest.ProductUnit, opt => opt.MapFrom(src => src.ProductUnit))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId));
    }
}
