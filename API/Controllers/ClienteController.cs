using FlightReservationAPI.Application.DTOs.Cliente;
using FlightReservationAPI.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace FlightReservationAPI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteService _clienteService;

        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        /// <summary>
        /// Obtiene todos los clientes activos.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllClientes()
        {
            var clientes = await _clienteService.GetAllClientesAsync();
            return Ok(clientes);
        }

        /// <summary>
        /// Obtiene un cliente por su ID.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClienteById(Guid id)
        {
            var cliente = await _clienteService.GetClienteByIdAsync(id);
            if (cliente == null) return NotFound($"No se encontró un cliente con el ID {id}");
            return Ok(cliente);
        }

        /// <summary>
        /// Agrega un nuevo cliente.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateCliente([FromBody] CreateClienteDTO createClienteDto)
        {
            if (createClienteDto == null)
                return BadRequest("El cliente enviado no es válido.");

            var clienteCreado = await _clienteService.AddClienteAsync(createClienteDto);
            return CreatedAtAction(nameof(GetClienteById), new { id = clienteCreado.Id }, clienteCreado);
        }

        /// <summary>
        /// Actualiza los datos de un cliente.
        /// </summary>
        [HttpPut]
        public async Task<IActionResult> UpdateCliente([FromBody] UpdateClienteDTO updateClienteDto)
        {
            if (updateClienteDto == null)
                return BadRequest("Datos de actualización inválidos.");

            var result = await _clienteService.UpdateClienteAsync(updateClienteDto);
            if (!result) return NotFound($"No se encontró un cliente con el ID {updateClienteDto.Id}");

            return NoContent();
        }

        /// <summary>
        /// Elimina (soft delete) un cliente por ID.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(Guid id)
        {
            var result = await _clienteService.DeleteClienteAsync(id);
            if (!result) return NotFound($"No se encontró un cliente con el ID {id}");

            return NoContent();
        }
    }
}
