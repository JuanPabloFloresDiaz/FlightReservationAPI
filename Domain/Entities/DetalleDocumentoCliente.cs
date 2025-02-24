using FlightReservationAPI.Domain.Common;
using System.ComponentModel.DataAnnotations;
namespace FlightReservationAPI.Domain.Entities
{
    public class DetalleDocumentoCliente : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [StringLength(50)]
        public string Valor { get; set; } = string.Empty;

        // Relaciones
        public Guid DocumentoId { get; set; }
        public Documento Documento { get; set; } = null!;

        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;
    }
}
