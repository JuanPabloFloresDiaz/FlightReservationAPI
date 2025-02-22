using FlightReservationAPI.Domain.Interfaces;
using FlightReservationAPI.Domain.Entities;
using FlightReservationAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FlightReservationAPI.Infrastructure.Repositories
{
    public class DestinoRepository : IDestinoRepository
    {
        public Task AddAsync(Destino destino)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Destino>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Destino?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Destino destino)
        {
            throw new NotImplementedException();
        }
    }
}
