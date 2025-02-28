using Atalaya.Data.Repositories;
using Atalaya.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Atalaya.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class InventoryAdjustmentsController : ControllerBase
    {
        private readonly IInventoryAdjustmentsRepository _inventoryAdjustmentsRepository;

        public InventoryAdjustmentsController(IInventoryAdjustmentsRepository inventoryAdjustmentsRepository)
        {
            _inventoryAdjustmentsRepository = inventoryAdjustmentsRepository;
        }
        // POST api/<OCProgressController>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateInventoryAdjustments([FromBody] InventoryAdjustments inventoryAdjustments)
        {
            Response respCreateInventoryAdjustments = new Response();
            respCreateInventoryAdjustments.conflicts = new List<Conflicts>();

            return Ok(200);
        }
    }
}
