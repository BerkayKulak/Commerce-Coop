using ECommerce.NET_Angular.Core.DbModels;
using ECommerce.NET_Angular.Core.Interfaces;
using ECommerce.NET_Angular.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.NET_Angular.Core.Specifications;
using ECommerce.NET_Angular.Infrastructure.Data;

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

        public async Task<T> GetEntityWithSpec(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), spec);
        } 
    }
}
