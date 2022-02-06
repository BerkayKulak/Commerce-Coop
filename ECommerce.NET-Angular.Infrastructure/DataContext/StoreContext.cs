using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.NET_Angular.Core.DbModels;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.NET_Angular.Infrastructure.DataContext
{
    public class StoreContext : DbContext
    {
        // options  u DbContextten alır.
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

    }
}
