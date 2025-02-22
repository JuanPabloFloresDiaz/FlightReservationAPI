using FlightReservationAPI.Domain.Common;

namespace FlightReservationAPI.Domain.Entities
{
    public class Pais : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nombre { get; set; } = string.Empty;
        public string Nacionalidad { get; set; } = string.Empty;

        // Relación con Ciudad
        public ICollection<Ciudad> Ciudades { get; set; } = new List<Ciudad>();
        // Relación con Cliente
        public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
    }
}
