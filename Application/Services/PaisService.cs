using FlightReservationAPI.Application.DTOs.Pais;
using FlightReservationAPI.Domain.Entities;
using FlightReservationAPI.Domain.Interfaces;

namespace FlightReservationAPI.Application.Services
{
    public class PaisService
    {
        private readonly IPaisRepository _paisRepository;

        public PaisService(IPaisRepository paisRepository)
        {
            _paisRepository = paisRepository;
        }

        public async Task<IEnumerable<PaisDTO>> GetAllPaisesAsync()
        {
            var paises = await _paisRepository.GetAllAsync();
            return paises.Select(p => new PaisDTO
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Nacionalidad = p.Nacionalidad
            });
        }

        public async Task<PaisDTO?> GetPaisByIdAsync(Guid id)
        {
            var pais = await _paisRepository.GetByIdAsync(id);
            return pais == null ? null : new PaisDTO
            {
                Id = pais.Id,
                Nombre = pais.Nombre,
                Nacionalidad = pais.Nacionalidad
            };
        }

        public async Task<PaisDTO> AddPaisAsync(CreatePaisDTO paisDto)
        {
            var pais = new Pais
            {
                Nombre = paisDto.Nombre,
                Nacionalidad = paisDto.Nacionalidad
            };

            await _paisRepository.AddAsync(pais);
            return new PaisDTO
            {
                Id = pais.Id,
                Nombre = pais.Nombre,
                Nacionalidad = pais.Nacionalidad
            };
        }

        public async Task<bool> UpdatePaisAsync(UpdatePaisDTO paisDto)
        {
            var pais = await _paisRepository.GetByIdAsync(paisDto.Id);
            if (pais == null) return false;

            if (!string.IsNullOrEmpty(paisDto.Nombre))
                pais.Nombre = paisDto.Nombre;

            if (!string.IsNullOrEmpty(paisDto.Nacionalidad))
                pais.Nacionalidad = paisDto.Nacionalidad;

            await _paisRepository.UpdateAsync(pais);
            return true;
        }

        public async Task<bool> DeletePaisAsync(Guid id)
        {
            var pais = await _paisRepository.GetByIdAsync(id);
            if (pais == null) return false;

            await _paisRepository.DeleteAsync(id);
            return true;
        }
    }
}