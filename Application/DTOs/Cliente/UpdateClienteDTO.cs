using System.ComponentModel.DataAnnotations;

namespace FlightReservationAPI.Application.DTOs.Cliente
{
    public class UpdateClienteDTO
    {
        public Guid Id { get; set; }

        [StringLength(50)]
        public string? Nombre { get; set; }

        [StringLength(50)]
        public string? Apellido { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string? Email { get; set; }

        [Phone]
        [StringLength(20)]
        public string? Telefono { get; set; }

        [StringLength(100)]
        public string? Direccion { get; set; }

        public Guid? CiudadId { get; set; }

        public Guid? NacionalidadId { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaNacimiento { get; set; }

        public Domain.Entities.Cliente.GeneroEnum? Genero { get; set; }

        public Domain.Entities.Cliente.EstadoCivilEnum? EstadoCivil { get; set; }
    }
}