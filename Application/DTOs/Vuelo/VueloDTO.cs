namespace FlightReservationAPI.Application.DTOs.Vuelo
{
    public class VueloDTO
    {
        public Guid Id { get; set; }
        public string NumeroVuelo { get; set; } = string.Empty;
        public DateTime FechaSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public Guid DestinoId { get; set; }

    }
}
