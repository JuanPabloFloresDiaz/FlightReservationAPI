using FlightReservationAPI.Domain.Interfaces;
using FlightReservationAPI.Domain.Entities;
using FlightReservationAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FlightReservationAPI.Infrastructure.Repositories
{
    public class PaisRepository : IPaisRepository
    {
        public Task AddAsync(Pais pais)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pais>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Pais> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Pais pais)
        {
            throw new NotImplementedException();
        }
    }
}
