using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.NET_Angular.Core.DbModels;
using ECommerce.NET_Angular.Core.Interfaces;

namespace ECommerce.NET_Angular.Infrastructure.Implements
{
    public class PaymentService:IPaymentService
    {
        public Task<CustomerBasket> CreateOrPaymentIntent(string basketId)
        {
            throw new NotImplementedException();
        }
    }
}
