using FlightReservationAPI.Domain.Common;
using System.ComponentModel.DataAnnotations;
namespace FlightReservationAPI.Domain.Entities
{
    public class TipoDocumento : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; } = string.Empty;

        // Relación
        public ICollection<Documento> Documentos { get; set; } = new List<Documento>();
    }
}
