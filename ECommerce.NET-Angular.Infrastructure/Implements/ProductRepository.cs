using ECommerce.NET_Angular.Core.DbModels;
using ECommerce.NET_Angular.Core.Interfaces;
using ECommerce.NET_Angular.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.NET_Angular.Infrastructure.Implements
{
    public class ProductRepository:IProductRepository
    {
        private readonly StoreContext _context;
        public ProductRepository(StoreContext storeContext)
        {
            _context = storeContext;
        }

        /// <summary>
        /// İd ye göre getirir
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products.
                // Objeyi de içerisine alıyoruz. objenin içi dolu ise gösterir.
                Include(p=>p.ProductBrand).
                Include(p=>p.ProductType)
                .FirstOrDefaultAsync(p=>p.Id==id);
        }

        /// <summary>
        /// Tüm ürünleri listeler
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IReadOnlyList<Product>> GetProductAsync()
        {
            return await _context.Products.
                Include(p=>p.ProductBrand).
                Include(p=>p.ProductType).
                ToListAsync();
        }

        public async Task<IReadOnlyList<ProductType>> GetProductTypesAsync()
        {
            return await _context.ProductTypes.ToListAsync();
        }

        public async Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync()
        {
            return await _context.ProductBrands.ToListAsync();
        }
    }
}
