using Microsoft.AspNetCore.Mvc;
using ParcialBackend.Models;

namespace ParcialBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EleccionesController : ControllerBase
    {
        private readonly Fg100220Fa100620Context _context;

        public EleccionesController(Fg100220Fa100620Context context) { 
            _context = context;
        }

        [HttpGet]
        [Route("Elecciones")]
        public async Task<IActionResult> GetElecciones() {
            List<Elecciones2019> listElecciones = _context.Elecciones2019s.ToList();
            try {
                if(listElecciones != null) { 
                    return Ok(listElecciones);
                }
                return Ok("No hay campos");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
