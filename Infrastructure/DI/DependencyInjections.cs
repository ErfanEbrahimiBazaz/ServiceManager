using Infrastructure.DbContexts;
using Infrastructure.Mappers;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.DI;

public static class DependencyInjections
{
    public static IServiceCollection AddProductContexts(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<ProductAggregateContext>(options => options.UseSqlServer(connectionString, b => b.MigrationsAssembly("ServiceManager")));
        return services;
    }

    public static IServiceCollection AddProductMapper(this IServiceCollection services)
    {
        //services.AddAutoMapper(cfg => cfg.AddProfile<ProductMapper>());
        services.AddAutoMapper(typeof(ProductMapper).Assembly);
        return services;
    }

    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ProductAggregateRepository>();
        return services;
    }
}
