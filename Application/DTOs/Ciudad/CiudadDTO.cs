namespace FlightReservationAPI.Application.DTOs.Ciudad
{
    public class CiudadDTO
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string CodigoPostal { get; set; } = string.Empty;
        public Guid PaisId { get; set; }
    }
}