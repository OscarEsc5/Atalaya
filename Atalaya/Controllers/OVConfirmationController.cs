using Atalaya.Data.Repositories;
using Atalaya.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Atalaya.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class OVConfirmationController : ControllerBase
    {
        private readonly IOVConfirmationRepository _oVConfirmationRepository;

        public OVConfirmationController(IOVConfirmationRepository oVConfirmationRepository)
        {
            _oVConfirmationRepository = oVConfirmationRepository;
        }
        // PUT api/<OCProgressController>/5
        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateOVConfirmation([FromBody] OVConfirmation oVConfirmation)
        {
            Response respUpdateOVConfirmation = new Response();
            respUpdateOVConfirmation.conflicts = new List<Conflicts>();

            return Ok(200);
        }
    }
}
