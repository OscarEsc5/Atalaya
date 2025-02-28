using Atalaya.Data.Repositories;
using Atalaya.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Atalaya.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class PackingConfirmationController : ControllerBase
    {
        private readonly IPackingConfirmationRepository _packingConfirmation;

        public PackingConfirmationController(IPackingConfirmationRepository packingConfirmation)
        {
            _packingConfirmation = packingConfirmation;
        }
        // PUT api/<OCProgressController>/5
        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdatePackingConfirmation([FromBody] PackingConfirmation packingConfirmation)
        {
            Response respUpdatePackingConfirmation = new Response();
            respUpdatePackingConfirmation.conflicts = new List<Conflicts>();

            return Ok(200);
        }
    }
}
