using FlightReservationAPI.Domain.Entities;

namespace FlightReservationAPI.Domain.Interfaces
{
    public interface IVueloRepository
    {
        Task<IEnumerable<Vuelo>> GetAllAsync();
        Task<Vuelo> GetByIdAsync(Guid id);
        Task AddAsync(Vuelo vuelo);
        Task UpdateAsync(Vuelo vuelo);
        Task DeleteAsync(Guid id);
    }
}
