using Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.DI
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddProductContexts(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ProductAggregateContext>(options => options.UseSqlServer(connectionString, b => b.MigrationsAssembly("ServiceManager")));
            return services;
        }
    }
}
