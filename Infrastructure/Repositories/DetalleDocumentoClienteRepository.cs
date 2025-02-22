using FlightReservationAPI.Domain.Interfaces;
using FlightReservationAPI.Domain.Entities;
using FlightReservationAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FlightReservationAPI.Infrastructure.Repositories
{
    public class DetalleDocumentoClienteRepository : IDetalleDocumentoClienteRepository
    {
        public Task AddAsync(DetalleDocumentoCliente detalleDocumentoCliente)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DetalleDocumentoCliente>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DetalleDocumentoCliente?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(DetalleDocumentoCliente detalleDocumentoCliente)
        {
            throw new NotImplementedException();
        }
    }
}
