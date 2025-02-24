using System.ComponentModel.DataAnnotations;

namespace FlightReservationAPI.Application.DTOs.Pais
{
    public class UpdatePaisDTO
    {
        public Guid Id { get; set; }

        [StringLength(100)]
        public string? Nombre { get; set; }

        [StringLength(100)]
        public string? Nacionalidad { get; set; }
    }
}