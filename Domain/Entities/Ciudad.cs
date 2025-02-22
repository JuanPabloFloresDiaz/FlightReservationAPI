using FlightReservationAPI.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace FlightReservationAPI.Domain.Entities
{
    public class Ciudad : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
        [StringLength(10)]
        public string CodigoPostal { get; set; } = string.Empty;

        // Relación con País
        public Guid PaisId { get; set; }
        public Pais Pais { get; set; } = null!;

        // Relación con Destinos
        public ICollection<Destino> Destinos { get; set; } = new List<Destino>();

        // Relación con Clientes
        public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
    }
}
