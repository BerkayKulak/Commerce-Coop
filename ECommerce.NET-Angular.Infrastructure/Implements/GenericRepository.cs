using ECommerce.NET_Angular.Core.DbModels;
using ECommerce.NET_Angular.Core.Interfaces;
using ECommerce.NET_Angular.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.NET_Angular.Infrastructure.Implements
{
    public class GenericRepository<T>:IGenericRepository<T> where T:BaseEntity
    {
        private readonly StoreContext _context;
        public GenericRepository(StoreContext context)
        {
            _context = context;
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            // Burda Include metodu kullanıp ProductBrand gibi şeyleri getiremeyiz
            // Çünkü soyutlama işlemi gerçekleştirdik bu yüzden göremez. T olarak görür ve bu da BaseEntity olarak somuttur
            return await _context.Set<T>().ToListAsync();
        }
    }
}
