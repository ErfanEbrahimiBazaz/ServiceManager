﻿using Application.CQRS.Product.Query.GetAllProducts;
using AutoMapper;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<ProductEntity, GetAllProductsQueryResponse>();
    }
}
