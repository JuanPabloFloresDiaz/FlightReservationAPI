using FlightReservationAPI.Domain.Common;

namespace FlightReservationAPI.Domain.Entities
{
    public class Vuelo : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NumeroVuelo { get; set; } = string.Empty;
        public DateTime FechaSalida { get; set; }
        public DateTime FechaLlegada { get; set; }

        // Relación con Destino
        public Guid DestinoId { get; set; }
        public Destino Destino { get; set; } = null!;
    }
}
