namespace FlightReservationAPI.Application.DTOs.Pais
{
    public class PaisDTO
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Nacionalidad { get; set; } = string.Empty;
    }
}