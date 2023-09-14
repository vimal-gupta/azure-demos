using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        [HttpGet]
        [Route("inventory/check")]
        public IActionResult IsProductAvailable(int skuID, int quantiry)
        {

            return Ok(true);
        }
    }
}
