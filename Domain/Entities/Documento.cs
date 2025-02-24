using FlightReservationAPI.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace FlightReservationAPI.Domain.Entities
{
    public class Documento : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; } = string.Empty;

        // Relación con TipoDocumento
        public Guid TipoDocumentoId { get; set; }
        public TipoDocumento TipoDocumento { get; set; } = null!;
    }
}
