using FlightReservationAPI.Domain.Common;

namespace FlightReservationAPI.Domain.Entities
{
    public class Reserva : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string CodigoReserva { get; set; } = string.Empty;
        public Clase TipoClase { get; set; }
        public int NumeroAsiento { get; set; }
        // Relaciones
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;

        public Guid VueloId { get; set; }
        public Vuelo Vuelo { get; set; } = null!;

        public enum Clase
        {
            PrimeraClase,
            ClaseEjecutiva,
            ClaseEconomica
        }
    }
}
