namespace FlightReservationAPI.Application.DTOs.Destino
{
    public class DestinoDTO
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public bool Estado { get; set; } = true;
        public Guid CiudadId { get; set; }
    }
}
