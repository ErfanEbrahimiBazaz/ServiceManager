using Application.Mappers;
using Microsoft.Extensions.DependencyInjection;

namespace Application.DI;

public static class DependencyInjections
{
    public static IServiceCollection AddProductProfileMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(ProductProfile).Assembly);
        return services;
    }
}
