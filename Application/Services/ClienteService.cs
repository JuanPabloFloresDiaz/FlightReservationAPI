using FlightReservationAPI.Application.DTOs.Cliente;
using FlightReservationAPI.Domain.Entities;
using FlightReservationAPI.Domain.Interfaces;

namespace FlightReservationAPI.Application.Services
{
    public class ClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<IEnumerable<ClienteDTO>> GetAllClientesAsync()
        {
            var clientes = await _clienteRepository.GetAllAsync();
            return clientes.Select(c => new ClienteDTO
            {
                Id = c.Id,
                Nombre = c.Nombre,
                Apellido = c.Apellido,
                Codigo = c.Codigo,
                Email = c.Email,
                Telefono = c.Telefono,
                Direccion = c.Direccion,
                FechaNacimiento = c.FechaNacimiento,
                Genero = c.Genero,
                EstadoCivil = c.EstadoCivil,
                CiudadId = c.CiudadId,
                NacionalidadId = c.NacionalidadId
            });
        }

        public async Task<ClienteDTO?> GetClienteByIdAsync(Guid id)
        {
            var cliente = await _clienteRepository.GetByIdAsync(id);
            if (cliente == null) return null;

            return new ClienteDTO
            {
                Id = cliente.Id,
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                Codigo = cliente.Codigo,
                Email = cliente.Email,
                Telefono = cliente.Telefono,
                Direccion = cliente.Direccion,
                FechaNacimiento = cliente.FechaNacimiento,
                Genero = cliente.Genero,
                EstadoCivil = cliente.EstadoCivil,
                CiudadId = cliente.CiudadId,
                NacionalidadId = cliente.NacionalidadId
            };
        }

        public async Task<ClienteDTO> AddClienteAsync(CreateClienteDTO newCliente)
        {
            var cliente = new Cliente
            {
                Nombre = newCliente.Nombre,
                Apellido = newCliente.Apellido,
                Email = newCliente.Email,
                Telefono = newCliente.Telefono,
                Direccion = newCliente.Direccion,
                CiudadId = newCliente.CiudadId,
                NacionalidadId = newCliente.NacionalidadId,
                FechaNacimiento = newCliente.FechaNacimiento,
                Genero = newCliente.Genero,
                EstadoCivil = newCliente.EstadoCivil
            };

            await _clienteRepository.AddAsync(cliente);

            return new ClienteDTO
            {
                Id = cliente.Id,
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                Codigo = cliente.Codigo,
                Email = cliente.Email,
                Telefono = cliente.Telefono,
                Direccion = cliente.Direccion,
                FechaNacimiento = cliente.FechaNacimiento,
                Genero = cliente.Genero,
                EstadoCivil = cliente.EstadoCivil,
                CiudadId = cliente.CiudadId,
                NacionalidadId = cliente.NacionalidadId
            };
        }

        public async Task<bool> UpdateClienteAsync(UpdateClienteDTO updateClienteDto)
        {
            var existingCliente = await _clienteRepository.GetByIdAsync(updateClienteDto.Id);
            if (existingCliente == null) return false;

            if (!string.IsNullOrEmpty(updateClienteDto.Nombre))
                existingCliente.Nombre = updateClienteDto.Nombre;

            if (!string.IsNullOrEmpty(updateClienteDto.Apellido))
                existingCliente.Apellido = updateClienteDto.Apellido;

            if (!string.IsNullOrEmpty(updateClienteDto.Email))
                existingCliente.Email = updateClienteDto.Email;

            if (!string.IsNullOrEmpty(updateClienteDto.Telefono))
                existingCliente.Telefono = updateClienteDto.Telefono;

            if (!string.IsNullOrEmpty(updateClienteDto.Direccion))
                existingCliente.Direccion = updateClienteDto.Direccion;

            if (updateClienteDto.CiudadId.HasValue)
                existingCliente.CiudadId = updateClienteDto.CiudadId.Value;

            if (updateClienteDto.NacionalidadId.HasValue)
                existingCliente.NacionalidadId = updateClienteDto.NacionalidadId.Value;

            if (updateClienteDto.FechaNacimiento.HasValue)
                existingCliente.FechaNacimiento = updateClienteDto.FechaNacimiento.Value;

            if (updateClienteDto.Genero.HasValue)
                existingCliente.Genero = updateClienteDto.Genero.Value;

            if (updateClienteDto.EstadoCivil.HasValue)
                existingCliente.EstadoCivil = updateClienteDto.EstadoCivil.Value;

            await _clienteRepository.UpdateAsync(existingCliente);
            return true;
        }

        public async Task<bool> DeleteClienteAsync(Guid id)
        {
            var cliente = await _clienteRepository.GetByIdAsync(id);
            if (cliente == null) return false;

            await _clienteRepository.DeleteAsync(id);
            return true;
        }
    }
}