using System.ComponentModel.DataAnnotations;
namespace FlightReservationAPI.Application.DTOs.TipoDocumento
{
    public class CreateTipoDocumentoDTO
    {
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;
    }
}
