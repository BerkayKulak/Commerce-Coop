using System;
using ECommerce.NET_Angular.Core.DbModels;
using ECommerce.NET_Angular.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECommerce.NET_Angular.API.Controllers
{

    public class BasketController : BaseApiController
    {
        private readonly IBasketRepository _basketRepository;

        public BasketController(IBasketRepository basketRepository)
        {
            _basketRepository = basketRepository;
        }


        [HttpGet]
        public async Task<ActionResult<CustomerBasket>> GetBasketById(string id)
        {
            var basket = await _basketRepository.GetBasketAsync(id);

            return Ok(basket ?? new CustomerBasket(id));

        }

        [HttpPost]
        public async Task<ActionResult<CustomerBasket>> UpdateBasket(CustomerBasket basket)
        {
            if (basket.Id == null || basket.Id == "undefined")
            {
                var newGuidValue = Guid.NewGuid();
                basket.Id = newGuidValue.ToString();
            }

            var updatedBasket = await _basketRepository.UpdateBasketAsync(basket);

            return Ok(updatedBasket);
        }

        [HttpDelete]
        public async Task DeleteBasketAsync(string id)
        {
            await _basketRepository.DeleteBasketAsync(id);
        }
    }
}
