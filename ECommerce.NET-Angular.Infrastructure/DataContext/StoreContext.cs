using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.NET_Angular.Core.DbModels;
using ECommerce.NET_Angular.Core.DbModels.Identity;
using ECommerce.NET_Angular.Core.DbModels.OrderAggregate;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Address = ECommerce.NET_Angular.Core.DbModels.Identity.Address;

namespace ECommerce.NET_Angular.Infrastructure.DataContext
{
    public class StoreContext : IdentityDbContext<AppUser>
    {
        // options  u DbContextten alır.
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<DeliveryMethod> DeliveryMethods { get; set; }

    }
}
