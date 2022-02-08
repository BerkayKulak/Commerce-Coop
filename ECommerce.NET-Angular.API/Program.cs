using ECommerce.NET_Angular.Core.DbModels.Identity;
using ECommerce.NET_Angular.Infrastructure.DataContext;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace ECommerce.NET_Angular.API
{
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    CreateHostBuilder(args).Build().Run();
        //}

        //    public static async Task Main(string[] args)
        //    {
        //        var host = CreateHostBuilder(args).Build();

        //        using (var scope = host.Services.CreateScope())
        //        {
        //            var services = scope.ServiceProvider;

        //            var loggerFactory = services.GetRequiredService<ILoggerFactory>();

        //            try
        //            {
        //                var userManager = services.GetRequiredService<UserManager<AppUser>>();

        //                var identityContext = services.GetRequiredService<StoreContext>();

        //                await identityContext.Database.MigrateAsync();

        //                await AppIdentityDbContextSeed.SeedUserAsync(userManager);




        //            }
        //            catch (Exception e)
        //            {
        //                var logger = loggerFactory.CreateLogger<Program>();

        //                logger.LogError(e,"An Error Ocurred during migration");

        //                throw;
        //            }
        //        }


        //    }

        //    public static IHostBuilder CreateHostBuilder(string[] args) =>
        //        Host.CreateDefaultBuilder(args)
        //            .ConfigureWebHostDefaults(webBuilder =>
        //            {
        //                webBuilder.UseStartup<Startup>();
        //            });
        //}


        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}

