using System.ComponentModel.DataAnnotations;
namespace FlightReservationAPI.Application.DTOs.Destino
{
    public class CreateDestinoDTO
    {
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;
        [Required]
        public bool Estado { get; set; } = true;
        [Required]
        public Guid CiudadId { get; set; }
    }
}
