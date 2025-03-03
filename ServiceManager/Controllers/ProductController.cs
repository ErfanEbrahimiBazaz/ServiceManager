using Application.CQRS.Product.Query.GetAllProducts;
using Core.Dtos.ProductAggregate;
using Core.InputModels;
using Infrastructure.Repositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ServiceManager.Controllers;

[ApiController]
[Route("api/Product")]
public class ProductController(ProductAggregateRepository productRepository,
                               IMediator mediator): ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateProdcut([FromBody] ProductCreateDto productCreateDto)
    {
        // validation
        // mapping
        var productEntityId = await productRepository.CreateProduct(productCreateDto);
        await productRepository.SaveChangesAysnc();
        return CreatedAtRoute("GetProductById", routeValues: new { productId = productEntityId }, value: productEntityId);
    }

    [HttpGet("{productId}", Name ="GetProductById")]
    public async Task<ActionResult<ProductDto>> GetProductById(Guid productId)
    {
        //validation ProductExistsAsync
        var ProductDto = await productRepository.GetProductById(productId);
        return Ok(ProductDto);
    }

    [HttpGet]
    public async Task<ActionResult<GetAllProductsQueryResponse>> GetAllProducts()
    {
        var response = await mediator.Send(new GetAllProductsQueryResponse());
        return Ok(response);
    }
}
