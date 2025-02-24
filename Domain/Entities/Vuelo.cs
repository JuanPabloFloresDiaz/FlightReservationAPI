using FlightReservationAPI.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace FlightReservationAPI.Domain.Entities
{
    public class Vuelo : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [StringLength(50)]
        public string NumeroVuelo { get; set; } = string.Empty;
        [Required]
        public DateTime FechaSalida { get; set; }
        [Required]
        public DateTime FechaLlegada { get; set; }

        // Relación con Destino
        public Guid DestinoId { get; set; }
        public Destino Destino { get; set; } = null!;
    }
}
