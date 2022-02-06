using ECommerce.NET_Angular.Infrastructure.DataContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.NET_Angular.API.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly StoreContext _context;

        public BuggyController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet("notfound")]
        public ActionResult GetNotFoundRequest()
        {
            var product = _context.Products.Find(5);

            if (product == null)
            {
                return NotFound();

            }
            return Ok();

        }

        [HttpGet("servererror")]
        public ActionResult GetServerError()
        {
            var product = _context.Products.Find(5);

            var productToReturn = product.ToString();

            return Ok();

        }

        [HttpGet("badrequest")]
        public ActionResult GetBadRequest()
        {

            return BadRequest();

        }

        [HttpGet("badrequest/{id}")]
        public ActionResult GetNotFoundRequest(int id)
        {

            return Ok();

        }
    }
}
