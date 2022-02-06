using System.Collections.Generic;
using System.Threading.Tasks;
using ECommerce.NET_Angular.Core.DbModels;

namespace ECommerce.NET_Angular.Core.Interfaces
{
    // verilen değerler BaseEntityden türemeliler
    // ve newlenebileen değerler olmalı, interface ya da abstract class veremez.
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();

    }
}
