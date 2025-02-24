using System.ComponentModel.DataAnnotations;
namespace FlightReservationAPI.Application.DTOs.DetalleDocumentoCliente
{
    public class CreateDetalleDocumentoClienteDTO
    {
        [Required]
        [StringLength(20)]
        public string Valor { get; set; } = string.Empty;
        [Required]
        public Guid DocumentoId { get; set; }
        [Required]
        public Guid ClienteId { get; set; }
    }
}
