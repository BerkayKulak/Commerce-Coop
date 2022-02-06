using ECommerce.NET_Angular.Core.DbModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.NET_Angular.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);

        // değişiklikleri yapamayacağımız bir liste
        Task<IReadOnlyList<Product>> GetProductAsync();
    }
}
