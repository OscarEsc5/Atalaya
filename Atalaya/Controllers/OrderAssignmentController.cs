using Atalaya.Data.Repositories;
using Atalaya.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Atalaya.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class OrderAssignmentController : ControllerBase
    {
        private readonly IOrderAssignmentRepository _orderAssignment;

        public OrderAssignmentController(IOrderAssignmentRepository orderAssignment)
        {
            _orderAssignment = orderAssignment;
        }
        // PUT api/<OCProgressController>/5
        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateOCProgress([FromBody] OrderAssignment orderAssignment)
        {
            Response respUpdateOrderAssignment = new Response();
            respUpdateOrderAssignment.conflicts = new List<Conflicts>();

            return Ok(200);
        }
    }
}
