using FlightReservationAPI.Application.DTOs.Pais;
using FlightReservationAPI.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace FlightReservationAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaisesController : ControllerBase
    {
        private readonly PaisService _paisService;

        public PaisesController(PaisService paisService)
        {
            _paisService = paisService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaisDTO>>> GetAll()
        {
            var paises = await _paisService.GetAllPaisesAsync();
            return Ok(paises);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PaisDTO>> GetById(Guid id)
        {
            var pais = await _paisService.GetPaisByIdAsync(id);
            return pais != null ? Ok(pais) : NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<PaisDTO>> Create(CreatePaisDTO paisDto)
        {
            var newPais = await _paisService.AddPaisAsync(paisDto);
            return CreatedAtAction(nameof(GetById), new { id = newPais.Id }, newPais);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, UpdatePaisDTO paisDto)
        {
            if (id != paisDto.Id) return BadRequest();
            var result = await _paisService.UpdatePaisAsync(paisDto);
            return result ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _paisService.DeletePaisAsync(id);
            return result ? NoContent() : NotFound();
        }
    }
}