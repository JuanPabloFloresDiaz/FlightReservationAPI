using FlightReservationAPI.Domain.Entities;

namespace FlightReservationAPI.Domain.Interfaces
{
    public interface IDetalleDocumentoClienteRepository
    {
        Task<IEnumerable<DetalleDocumentoCliente>> GetAllAsync();
        Task<DetalleDocumentoCliente?> GetByIdAsync(Guid id);
        Task AddAsync(DetalleDocumentoCliente detalleDocumentoCliente);
        Task UpdateAsync(DetalleDocumentoCliente detalleDocumentoCliente);
        Task DeleteAsync(Guid id);
    }
}
