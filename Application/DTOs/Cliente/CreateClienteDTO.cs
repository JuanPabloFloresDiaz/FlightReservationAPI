using System.ComponentModel.DataAnnotations;

namespace FlightReservationAPI.Application.DTOs.Cliente
{
    public class CreateClienteDTO
    {
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [Phone]
        [StringLength(20)]
        public string Telefono { get; set; } = string.Empty;

        [StringLength(100)]
        public string Direccion { get; set; } = string.Empty;

        [Required]
        public Guid CiudadId { get; set; }

        [Required]
        public Guid NacionalidadId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public Domain.Entities.Cliente.GeneroEnum Genero { get; set; }

        [Required]
        public Domain.Entities.Cliente.EstadoCivilEnum EstadoCivil { get; set; }
    }
}