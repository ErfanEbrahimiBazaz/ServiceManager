using Core.InputModels;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ServiceManager.Controllers;

[ApiController]
[Route("api/Product")]
public class ProductController(ProductAggregateRepository productRepository): ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateProdcut([FromBody] ProductCreateDto productCreateDto)
    {
        // validation
        // mapping
        await productRepository.CreateProduct(productCreateDto);
        await productRepository.SaveChangesAysnc();
        return NoContent();
    }

    
}
