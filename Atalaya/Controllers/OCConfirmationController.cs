using Atalaya.Data.Repositories;
using Atalaya.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Atalaya.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class OCConfirmationController : ControllerBase
    {
        private readonly IOCConfirmationRepository _oCConfirmationRepository;

        public OCConfirmationController(IOCConfirmationRepository oCConfirmationRepository)
        {
            _oCConfirmationRepository = oCConfirmationRepository;
        }
        // PUT api/<OCProgressController>/5
        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateOCConfirmation([FromBody] OCConfirmation oCConfirmation)
        {
            Response respUpdateOCConfirmation = new Response();
            respUpdateOCConfirmation.conflicts = new List<Conflicts>();

            return Ok(200);
        }
    }
}
