using FlightReservationAPI.Domain.Interfaces;
using FlightReservationAPI.Domain.Entities;
using FlightReservationAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FlightReservationAPI.Infrastructure.Repositories
{
    public class TipoDocumentoRepository : ITipoDocumentoRepository
    {
        public Task AddAsync(TipoDocumento tipoDocumento)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TipoDocumento>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TipoDocumento> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TipoDocumento tipoDocumento)
        {
            throw new NotImplementedException();
        }
    }
}
