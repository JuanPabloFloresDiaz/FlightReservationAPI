using FlightReservationAPI.Domain.Common;
using System.ComponentModel.DataAnnotations;
namespace FlightReservationAPI.Domain.Entities
{
    public class Pais : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; } = string.Empty;
        [StringLength(50)]
        [Required]
        public string Nacionalidad { get; set; } = string.Empty;

        // Relación con Ciudad
        public ICollection<Ciudad> Ciudades { get; set; } = new List<Ciudad>();
        // Relación con Cliente
        public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
    }
}
