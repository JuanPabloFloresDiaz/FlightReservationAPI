using FlightReservationAPI.Domain.Entities;

namespace FlightReservationAPI.Domain.Interfaces
{
    public interface IDocumentoRepository
    {
        Task<IEnumerable<Documento>> GetAllAsync();
        Task<Documento?> GetByIdAsync(Guid id);
        Task AddAsync(Documento documento);
        Task UpdateAsync(Documento documento);
        Task DeleteAsync(Guid id);
    }
}
