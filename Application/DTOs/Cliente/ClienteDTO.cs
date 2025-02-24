namespace FlightReservationAPI.Application.DTOs.Cliente
{
    public class ClienteDTO
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public Domain.Entities.Cliente.GeneroEnum Genero { get; set; }
        public Domain.Entities.Cliente.EstadoCivilEnum EstadoCivil { get; set; }
        public DateTime FechaRegistro { get; set; }
        public Guid CiudadId { get; set; }
        public Guid NacionalidadId { get; set; }
    }
}