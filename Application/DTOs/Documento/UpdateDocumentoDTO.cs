using System.ComponentModel.DataAnnotations;
namespace FlightReservationAPI.Application.DTOs.Documento
{
    public class UpdateDocumentoDTO
    {
        [Required]
        public Guid Id { get; set; }
        [StringLength(100)]
        [Required]
        public string Nombre { get; set; } = string.Empty;
        [Required]
        public Guid TipoDocumentoId { get; set; }
    }
}
