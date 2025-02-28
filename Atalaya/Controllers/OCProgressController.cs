using Atalaya.Data.Repositories;
using Atalaya.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Atalaya.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class OCProgressController : ControllerBase
    {
        private readonly IOCProgressRepository _oCProgressRepository;

        public OCProgressController(IOCProgressRepository oCProgressRepository)
        {
            _oCProgressRepository = oCProgressRepository;
        }
        // PUT api/<OCProgressController>/5
        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateOCProgress([FromBody] OCProgress oCProgress)
        {
            Response respUpdateOCProgress = new Response();
            respUpdateOCProgress.conflicts = new List<Conflicts>();

            return Ok(200);
        }

    }
}
