using FlightReservationAPI.Domain.Interfaces;
using FlightReservationAPI.Domain.Entities;
using FlightReservationAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FlightReservationAPI.Infrastructure.Repositories
{
    public class VueloRepository : IVueloRepository
    {
        public Task AddAsync(Vuelo vuelo)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vuelo>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Vuelo> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Vuelo vuelo)
        {
            throw new NotImplementedException();
        }
    }
}
