using ECommerce.NET_Angular.Core.Interfaces;
using ECommerce.NET_Angular.Infrastructure.Data;
using ECommerce.NET_Angular.Infrastructure.Implements;
using ECommerce.NET_Angular.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.NET_Angular.API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        // startupun içerisindeki ConfigureServicesin içerisini azaltmak. 
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<ITokenService, TokenService>();

            services.AddScoped<IOrderService, OrderService>();

            services.AddScoped<IPaymentService, PaymentService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<IBasketRepository, BasketRepository>();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return services;

        }
    }
}
