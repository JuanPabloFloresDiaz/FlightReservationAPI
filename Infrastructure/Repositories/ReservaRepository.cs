using FlightReservationAPI.Domain.Interfaces;
using FlightReservationAPI.Domain.Entities;
using FlightReservationAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FlightReservationAPI.Infrastructure.Repositories
{
    public class ReservaRepository : IReservaRepository
    {
        public Task AddAsync(Reserva reserva)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Reserva>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Reserva?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Reserva reserva)
        {
            throw new NotImplementedException();
        }
    }
}
