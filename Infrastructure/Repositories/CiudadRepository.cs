using FlightReservationAPI.Domain.Interfaces;
using FlightReservationAPI.Domain.Entities;
using FlightReservationAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FlightReservationAPI.Infrastructure.Repositories
{
    public class CiudadRepository : ICiudadRepository
    {
        public Task AddAsync(Ciudad ciudad)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ciudad>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Ciudad?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Ciudad ciudad)
        {
            throw new NotImplementedException();
        }
    }
}
