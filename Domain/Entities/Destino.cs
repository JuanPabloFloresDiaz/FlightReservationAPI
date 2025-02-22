using FlightReservationAPI.Domain.Common;

namespace FlightReservationAPI.Domain.Entities
{
    public class Destino : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nombre { get; set; } = string.Empty;
        public bool Activo { get; set; } = true; // Estado del destino

        // Relación con Ciudad
        public Guid CiudadId { get; set; }
        public Ciudad Ciudad { get; set; } = null!;

        // Relación con Vuelos
        public ICollection<Vuelo> Vuelos { get; set; } = new List<Vuelo>();
    }
}
