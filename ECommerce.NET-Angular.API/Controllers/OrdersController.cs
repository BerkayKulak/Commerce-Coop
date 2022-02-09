using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using ECommerce.NET_Angular.API.Dtos;
using ECommerce.NET_Angular.API.Errors;
using ECommerce.NET_Angular.API.Extensions;
using ECommerce.NET_Angular.Core.DbModels.OrderAggregate;
using ECommerce.NET_Angular.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.NET_Angular.API.Controllers
{
    [Authorize]
    public class OrdersController : BaseApiController
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrdersController(IOrderService orderService,IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<Order>> CreateOrder(OrderDto orderDto)
        {
            var email = HttpContext.User.RetrieveEmailFromPrimcipal();

            var address = _mapper.Map<AddressDto, Address>(orderDto.ShipToAddress);

            var order = await _orderService.CreateOrderAsync(email, orderDto.DeliveryMethod, orderDto.BasketId, address);

            if (order == null) return BadRequest(new ApiResponse(400, "Problem Creating Order"));

            return Ok(order);
        }
    }
}
