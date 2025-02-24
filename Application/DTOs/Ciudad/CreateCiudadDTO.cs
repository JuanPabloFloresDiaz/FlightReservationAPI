using System.ComponentModel.DataAnnotations;

namespace FlightReservationAPI.Application.DTOs.Ciudad
{
    public class CreateCiudadDTO
    {
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [StringLength(10)]
        public string CodigoPostal { get; set; } = string.Empty;

        [Required]
        public Guid PaisId { get; set; }
    }
}