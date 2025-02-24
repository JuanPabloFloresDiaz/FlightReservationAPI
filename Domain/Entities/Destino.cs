using FlightReservationAPI.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace FlightReservationAPI.Domain.Entities
{
    public class Destino : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [StringLength(100)]
        [Required]
        public string Nombre { get; set; } = string.Empty;
        [Required]
        public bool Estado { get; set; } = true; // Estado del destino

        // Relación con Ciudad
        public Guid CiudadId { get; set; }
        public Ciudad Ciudad { get; set; } = null!;

        // Relación con Vuelos
        public ICollection<Vuelo> Vuelos { get; set; } = new List<Vuelo>();
    }
}
