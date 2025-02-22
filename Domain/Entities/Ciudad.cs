using FlightReservationAPI.Domain.Common;

namespace FlightReservationAPI.Domain.Entities
{
    public class Ciudad : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nombre { get; set; } = string.Empty;

        // Relación con País
        public Guid PaisId { get; set; }
        public Pais Pais { get; set; } = null!;

        // Relación con Destinos
        public ICollection<Destino> Destinos { get; set; } = new List<Destino>();

        // Relación con Clientes
        public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
    }
}
