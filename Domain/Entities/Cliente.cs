using FlightReservationAPI.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace FlightReservationAPI.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; } = string.Empty;

        [StringLength(20)]
        public string Codigo { get; set; } = GenerarCodigoCliente();

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [Phone]
        [StringLength(20)]
        public string Telefono { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [StringLength(100)]
        public string Direccion { get; set; } = string.Empty;

        // Relaciones geográficas
        public Guid CiudadId { get; set; }
        public Ciudad Ciudad { get; set; } = null!;

        public Guid NacionalidadId { get; set; }
        public Pais Nacionalidad { get; set; } = null!;

        public GeneroEnum Genero { get; set; }

        public EstadoCivilEnum EstadoCivil { get; set; }

        // Relaciones
        public ICollection<DetalleDocumentoCliente> Documentos { get; set; } = new List<DetalleDocumentoCliente>();
        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();

        private static string GenerarCodigoCliente()
        {
            var fecha = DateTime.Now.ToString("yyyyMM");
            var random = new Random().Next(1000, 9999);
            return $"CLI-{fecha}-{random}";
        }


        public enum GeneroEnum
        {
            Masculino,
            Femenino,
            Otro,
            PrefieroNoDecirlo
        }

        public enum EstadoCivilEnum
        {
            Soltero,
            Casado,
            Divorciado,
            Viudo,
            UnionLibre
        }

    }
}
