using Atalaya.Data.Repositories;
using Atalaya.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Atalaya.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class WarehouseTransferController : ControllerBase
    {
        private readonly IWarehouseTransferRepository _warehouseTransferRepository;

        public WarehouseTransferController(IWarehouseTransferRepository warehouseTransferRepository)
        {
            _warehouseTransferRepository = warehouseTransferRepository;
        }
        // POST api/<OCProgressController>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateWarehouseTransfer([FromBody] WarehouseTransfer warehouseTransfer)
        {
            Response respCreateWarehouseTransfer = new Response();
            respCreateWarehouseTransfer.conflicts = new List<Conflicts>();

            return Ok(200);
        }
    }
}
