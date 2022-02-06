using System.Collections.Generic;
using System.Threading.Tasks;
using ECommerce.NET_Angular.Core.DbModels;
using ECommerce.NET_Angular.Core.Interfaces;
using ECommerce.NET_Angular.Infrastructure.DataContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.NET_Angular.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductsController(IProductRepository context)
        {
            _productRepository = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var data = await _productRepository.GetProductAsync();
            return Ok(data);

        }
        

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProducts(int id)
        {
            return await _productRepository.GetProductByIdAsync(id);

        }
    }
}
