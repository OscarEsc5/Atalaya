using Atalaya.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace Atalaya.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemMasterController : Controller
    {

        // POST: ItemMasterController/Create
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create([FromBody] ItemMaster itemMaster)
        {
            Response respCreateItemMaster = new Response();
            respCreateItemMaster.conflicts = new List<Conflicts>();
            List<string> errores = new List<string>();

            foreach (var prop in typeof(ItemMaster).GetProperties())
            {
                var valor = prop.GetValue(itemMaster);

                switch (valor)
                {
                    case string str when string.IsNullOrWhiteSpace(str):
                        errores.Add($"El campo {prop.Name} no puede estar vacío.");
                        break;

                    case decimal dec when dec == 0:
                        errores.Add($"El campo {prop.Name} no puede ser 0.");
                        break;
                }
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Si hay errores, devolver BadRequest con los errores concatenados
            if (errores.Any())
            {
                respCreateItemMaster.conflicts.Add(new Conflicts
                {
                    Problems = true,
                    Description = string.Join("\n", errores)
                });
                return BadRequest(respCreateItemMaster);
            }

            // Si todo está bien, retornar éxito
            respCreateItemMaster.conflicts.Add(new Conflicts
            {
                Problems = false,
                Description = "Creado Correctamente"
            });

            return Created("created", respCreateItemMaster);

        }

    }
}
