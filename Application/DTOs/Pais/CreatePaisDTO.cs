using System.ComponentModel.DataAnnotations;

namespace FlightReservationAPI.Application.DTOs.Pais
{
    public class CreatePaisDTO
    {
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Nacionalidad { get; set; } = string.Empty;
    }
}