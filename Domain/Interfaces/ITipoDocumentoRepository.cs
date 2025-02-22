using FlightReservationAPI.Domain.Entities;

namespace FlightReservationAPI.Domain.Interfaces
{
    public interface ITipoDocumentoRepository
    {
        Task<IEnumerable<TipoDocumento>> GetAllAsync();
        Task<TipoDocumento> GetByIdAsync(Guid id);
        Task AddAsync(TipoDocumento tipoDocumento);
        Task UpdateAsync(TipoDocumento tipoDocumento);
        Task DeleteAsync(Guid id);
    }
}
