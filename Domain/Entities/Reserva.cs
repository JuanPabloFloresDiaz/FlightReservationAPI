using FlightReservationAPI.Domain.Common;

namespace FlightReservationAPI.Domain.Entities
{
    public class Reserva : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime FechaReserva { get; set; } = DateTime.UtcNow;

        // Relaciones
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;

        public Guid VueloId { get; set; }
        public Vuelo Vuelo { get; set; } = null!;
    }
}
