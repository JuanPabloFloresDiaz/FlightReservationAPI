using FlightReservationAPI.Application.DTOs.Ciudad;
using FlightReservationAPI.Application.Services;
using Microsoft.AspNetCore.Mvc;
namespace FlightReservationAPI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CiudadController : ControllerBase
    {
        private readonly CiudadService _ciudadService;
        public CiudadController(CiudadService ciudadService)
        {
            _ciudadService = ciudadService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CiudadDTO>>> GetAll()
        {
            var ciudades = await _ciudadService.GetAllCiudadesAsync();
            return Ok(ciudades);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<CiudadDTO>> GetById(Guid id)
        {
            var ciudad = await _ciudadService.GetCiudadByIdAsync(id);
            return ciudad != null ? Ok(ciudad) : NotFound();
        }
        [HttpPost]
        public async Task<ActionResult<CiudadDTO>> Create(CreateCiudadDTO ciudadDto)
        {
            var newCiudad = await _ciudadService.AddCiudadAsync(ciudadDto);
            return CreatedAtAction(nameof(GetById), new { id = newCiudad.Id }, newCiudad);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, UpdateCiudadDTO ciudadDto)
        {
            if (id != ciudadDto.Id) return BadRequest();
            var result = await _ciudadService.UpdateCiudadAsync(ciudadDto);
            return result ? NoContent() : NotFound();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _ciudadService.DeleteCiudadAsync(id);
            return result ? NoContent() : NotFound();
        }
    }
}
