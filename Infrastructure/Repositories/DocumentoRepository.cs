using FlightReservationAPI.Domain.Interfaces;
using FlightReservationAPI.Domain.Entities;
using FlightReservationAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FlightReservationAPI.Infrastructure.Repositories
{
    public class DocumentoRepository : IDocumentoRepository
    {
        public Task AddAsync(Documento documento)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Documento>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Documento?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Documento documento)
        {
            throw new NotImplementedException();
        }
    }
}
