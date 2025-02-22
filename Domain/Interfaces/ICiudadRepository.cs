using FlightReservationAPI.Domain.Entities;

namespace FlightReservationAPI.Domain.Interfaces
{
    public interface ICiudadRepository
    {
        Task<IEnumerable<Ciudad>> GetAllAsync();
        Task<Ciudad?> GetByIdAsync(Guid id);
        Task AddAsync(Ciudad ciudad);
        Task UpdateAsync(Ciudad ciudad);
        Task DeleteAsync(Guid id);
    }
}
