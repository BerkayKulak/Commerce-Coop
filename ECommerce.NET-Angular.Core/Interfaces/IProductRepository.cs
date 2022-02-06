using ECommerce.NET_Angular.Core.DbModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.NET_Angular.Core.Interfaces
{
    public interface IProductRepository
    {
        /// <summary>
        /// İd ye göre getirir
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Product> GetProductByIdAsync(int id);

        // değişiklikleri yapamayacağımız bir liste
        /// <summary>
        /// Tüm ürünleri listeler
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IReadOnlyList<Product>> GetProductAsync();
    }
}
