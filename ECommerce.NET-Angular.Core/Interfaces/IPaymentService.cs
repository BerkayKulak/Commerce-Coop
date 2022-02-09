using ECommerce.NET_Angular.Core.DbModels;
using System.Threading.Tasks;

namespace ECommerce.NET_Angular.Core.Interfaces
{
    public interface IPaymentService
    {
        Task<CustomerBasket> CreateOrPaymentIntent(string basketId);
    }
}
