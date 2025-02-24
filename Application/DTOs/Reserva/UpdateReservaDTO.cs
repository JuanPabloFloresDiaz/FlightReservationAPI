using System.ComponentModel.DataAnnotations;
namespace FlightReservationAPI.Application.DTOs.Reserva
{
    public class UpdateReservaDTO
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [StringLength(100)]
        public string CodigoReserva { get; set; } = string.Empty;
        [Required]
        public Domain.Entities.Reserva.Clase TipoClase { get; set; }
        [Required]
        public int NumeroAsiento { get; set; }
        [Required]
        public Guid ClienteId { get; set; }
        [Required]
        public Guid VueloId { get; set; }
    }
}
