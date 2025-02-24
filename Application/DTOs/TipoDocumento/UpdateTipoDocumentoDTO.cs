using System.ComponentModel.DataAnnotations;
namespace FlightReservationAPI.Application.DTOs.TipoDocumento
{
    public class UpdateTipoDocumentoDTO
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;
    }
}
