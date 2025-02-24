using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Atalaya.Controllers
{
    [Route("api/protegido")]
    [ApiController]
    public class ProtegidoController : Controller
    {
        [HttpGet]
        [Authorize] // Solo accesible con un token válido
        public IActionResult GetData()
        {
            return Ok(new { Message = "Este es un endpoint protegido" });
        }
    }
}
