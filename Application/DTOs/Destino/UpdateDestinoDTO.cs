using System.ComponentModel.DataAnnotations;
namespace FlightReservationAPI.Application.DTOs.Destino
{
    public class UpdateDestinoDTO
    {
        public Guid Id { get; set; }
        [StringLength(100)]
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public bool? Estado { get; set; }
        [Required]
        public Guid? CiudadId { get; set; }

    }
}
