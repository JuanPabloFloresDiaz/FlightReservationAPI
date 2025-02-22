using FlightReservationAPI.Domain.Common;

namespace FlightReservationAPI.Domain.Entities
{
    public class DetalleDocumentoCliente : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Valor { get; set; } = string.Empty;

        // Relaciones
        public Guid DocumentoId { get; set; }
        public Documento Documento { get; set; } = null!;

        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;
    }
}
