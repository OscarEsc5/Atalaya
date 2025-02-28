using Atalaya.Data.Repositories;
using Atalaya.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Atalaya.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class LockTransferController : ControllerBase
    {
        private readonly ILockTransferRepository _lockTransferRepository;

        public LockTransferController(ILockTransferRepository lockTransferRepository)
        {
            _lockTransferRepository = lockTransferRepository;
        }
        // POST api/<OCProgressController>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateLockTransfer([FromBody] LockTransfer lockTransfer)
        {
            Response respCreateLockTransfer = new Response();
            respCreateLockTransfer.conflicts = new List<Conflicts>();

            return Ok(200);
        }
    }
}
