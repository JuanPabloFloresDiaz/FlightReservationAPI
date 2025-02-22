using FlightReservationAPI.Domain.Common;

namespace FlightReservationAPI.Domain.Entities
{
    public class Documento : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nombre { get; set; } = string.Empty;

        // Relación con TipoDocumento
        public Guid TipoDocumentoId { get; set; }
        public TipoDocumento TipoDocumento { get; set; } = null!;
    }
}
