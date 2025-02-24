using FlightReservationAPI.Domain.Common;
using System.ComponentModel.DataAnnotations;
namespace FlightReservationAPI.Domain.Entities
{
    public class Reserva : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [StringLength(50)]
        [Required]
        public string CodigoReserva { get; set; } = GenerarCodigoReserva();
        [Required]
        public Clase TipoClase { get; set; }
        [Required]
        public int NumeroAsiento { get; set; }
        // Relaciones
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;

        public Guid VueloId { get; set; }
        public Vuelo Vuelo { get; set; } = null!;

        private static string GenerarCodigoReserva()
        {
            var fecha = DateTime.Now.ToString("yyyyMM");
            var random = new Random().Next(1000, 9999);
            return $"RSV-{fecha}-{random}";
        }

        public enum Clase
        {
            PrimeraClase,
            ClaseEjecutiva,
            ClaseEconomica
        }
    }
}
