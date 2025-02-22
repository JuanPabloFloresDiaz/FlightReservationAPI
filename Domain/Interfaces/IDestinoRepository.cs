using FlightReservationAPI.Domain.Entities;

namespace FlightReservationAPI.Domain.Interfaces
{
    public interface IDestinoRepository
    {
        Task<IEnumerable<Destino>> GetAllAsync();
        Task<Destino?> GetByIdAsync(Guid id);
        Task AddAsync(Destino destino);
        Task UpdateAsync(Destino destino);
        Task DeleteAsync(Guid id);
    }
}
