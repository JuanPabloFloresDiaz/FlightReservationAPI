using System.ComponentModel.DataAnnotations;
namespace FlightReservationAPI.Application.DTOs.Documento
{
    public class CreateDocumentoDTO
    {
        [StringLength(100)]
        [Required]
        public string Nombre { get; set; } = string.Empty;
        public Guid TipoDocumentoId { get; set; }
    }
}
