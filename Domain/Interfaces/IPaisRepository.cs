using FlightReservationAPI.Domain.Entities;

namespace FlightReservationAPI.Domain.Interfaces
{
    public interface IPaisRepository
    {
        Task<IEnumerable<Pais>> GetAllAsync();
        Task<Pais?> GetByIdAsync(Guid id);
        Task AddAsync(Pais pais);
        Task UpdateAsync(Pais pais);
        Task DeleteAsync(Guid id);
    }
}
