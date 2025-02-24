using FlightReservationAPI.Application.DTOs.Ciudad;
using FlightReservationAPI.Domain.Entities;
using FlightReservationAPI.Domain.Interfaces;

namespace FlightReservationAPI.Application.Services
{
    public class CiudadService
    {
        private readonly ICiudadRepository _ciudadRepository;
        private readonly IPaisRepository _paisRepository;

        public CiudadService(ICiudadRepository ciudadRepository, IPaisRepository paisRepository)
        {
            _ciudadRepository = ciudadRepository;
            _paisRepository = paisRepository;
        }

        public async Task<IEnumerable<CiudadDTO>> GetAllCiudadesAsync()
        {
            var ciudades = await _ciudadRepository.GetAllAsync();
            return ciudades.Select(c => new CiudadDTO
            {
                Id = c.Id,
                Nombre = c.Nombre,
                CodigoPostal = c.CodigoPostal,
                PaisId = c.PaisId
            });
        }

        public async Task<CiudadDTO?> GetCiudadByIdAsync(Guid id)
        {
            var ciudad = await _ciudadRepository.GetByIdAsync(id);
            return ciudad == null ? null : new CiudadDTO
            {
                Id = ciudad.Id,
                Nombre = ciudad.Nombre,
                CodigoPostal = ciudad.CodigoPostal,
                PaisId = ciudad.PaisId
            };
        }

        public async Task<CiudadDTO> AddCiudadAsync(CreateCiudadDTO ciudadDto)
        {
            var ciudad = new Ciudad
            {
                Nombre = ciudadDto.Nombre,
                CodigoPostal = ciudadDto.CodigoPostal,
                PaisId = ciudadDto.PaisId
            };

            await _ciudadRepository.AddAsync(ciudad);
            return new CiudadDTO
            {
                Id = ciudad.Id,
                Nombre = ciudad.Nombre,
                CodigoPostal = ciudad.CodigoPostal,
                PaisId = ciudad.PaisId
            };
        }

        public async Task<bool> UpdateCiudadAsync(UpdateCiudadDTO ciudadDto)
        {
            var ciudad = await _ciudadRepository.GetByIdAsync(ciudadDto.Id);
            if (ciudad == null) return false;

            if (!string.IsNullOrEmpty(ciudadDto.Nombre))
                ciudad.Nombre = ciudadDto.Nombre;

            if (!string.IsNullOrEmpty(ciudadDto.CodigoPostal))
                ciudad.CodigoPostal = ciudadDto.CodigoPostal;

            if (ciudadDto.PaisId.HasValue)
                ciudad.PaisId = ciudadDto.PaisId.Value;

            await _ciudadRepository.UpdateAsync(ciudad);
            return true;
        }

        public async Task<bool> DeleteCiudadAsync(Guid id)
        {
            var ciudad = await _ciudadRepository.GetByIdAsync(id);
            if (ciudad == null) return false;

            await _ciudadRepository.DeleteAsync(id);
            return true;
        }
    }
}