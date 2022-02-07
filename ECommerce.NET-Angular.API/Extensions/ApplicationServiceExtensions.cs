using ECommerce.NET_Angular.Core.Interfaces;
using ECommerce.NET_Angular.Infrastructure.Implements;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.NET_Angular.API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        // startupun içerisindeki ConfigureServicesin içerisini azaltmak. 
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddSingleton<IBasketRepository, BasketRepository>();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return services;

        }
    }
}
