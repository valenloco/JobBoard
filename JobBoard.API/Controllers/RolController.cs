using Microsoft.AspNetCore.Mvc;
using JobBoard.API.Services;
using JobBoard.API.Entities;

namespace JobBoard.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolController : ControllerBase
    {
        private readonly RolService _rolService;

        public RolController(RolService rolService)
        {
            _rolService = rolService;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerTodos() 
        { 
            var roles = await _rolService.ObtenerTodos();
            return Ok(roles);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerPorId(int id) 
        {
            var rol = await _rolService.ObtenerPorId(id);
            return rol != null ? Ok(rol) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] Rol rol) 
        {
            var nuevoRol = await _rolService.Crear(rol);
            return CreatedAtAction(nameof(ObtenerPorId), new { id = nuevoRol.Id }, nuevoRol);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Actualizar(int id, [FromBody] Rol rolActualizado) 
        {
            var actualizarRol = await _rolService.Actualizar(id, rolActualizado);
            return actualizarRol != null ? Ok(actualizarRol) : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id) 
        {
            await _rolService.Eliminar(id);
            return NoContent();
        }
    }
}
