using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.NET_Angular.Core.DbModels;
using ECommerce.NET_Angular.Core.DbModels.OrderAggregate;
using ECommerce.NET_Angular.Core.Interfaces;
using ECommerce.NET_Angular.Infrastructure.Implements;

namespace ECommerce.NET_Angular.Infrastructure.Services
{
    public class OrderService:IOrderService
    {
        private readonly GenericRepository<Order> _orderRepo;
        private readonly IGenericRepository<DeliveryMethod> _deliveryMethoRepo;
        private readonly IGenericRepository<Product> _productRepo;
        private readonly IBasketRepository _basketRepo;

        public OrderService(GenericRepository<Order> orderRepo,
            IGenericRepository<DeliveryMethod> deliveryMethoRepo,
            IGenericRepository<Product> productRepo,
            IBasketRepository basketRepo)
        {
            _orderRepo = orderRepo;
            _deliveryMethoRepo = deliveryMethoRepo;
            _productRepo = productRepo;
            _basketRepo = basketRepo;
        }
        public async Task<Order> CreateOrderAsync(string buyerEmail, int deliveryMethodId, string basketId, Address shippingAddress)
        {
            var basket =await _basketRepo.GetBasketAsync(basketId);

            var items = new List<OrderItem>();

            foreach (var item in basket.Items)
            {
                var productItem = await _productRepo.GetByIdAsync(item.Id);

                var itemOrdered = new ProductItemOrdered(productItem.Id, productItem.Name, productItem.PictureUrl);

                var orderItem = new OrderItem(itemOrdered, productItem.Price, item.Quantity);

                items.Add(orderItem);
            }

            var deliveryMethod = await _deliveryMethoRepo.GetByIdAsync(deliveryMethodId);

            var subTotal = items.Sum(item => item.Price * item.Quantity);

            var order = new Order(buyerEmail, shippingAddress, deliveryMethod, items, subTotal);

            //TODO:save db;

            return order;


        }

        public Task<IReadOnlyList<Order>> GetOrderForUserAsync(string buyerEmail)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderByIdAsync(int id, string buyerEmail)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<DeliveryMethod>> GetDeliveryMethodAsync()
        {
            throw new NotImplementedException();
        }
    }
}
