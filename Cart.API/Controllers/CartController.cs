using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cart.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        [HttpGet]
        [Route("cart/add")]
        public IActionResult Add(int skuID, int quantiry, int cartID)
        {
            return Ok(true);
        }
    }
}
