namespace FlightReservationAPI.Application.DTOs.Reserva
{
    public class ReservaDTO
    {
        public Guid Id { get; set; }
        public string CodigoReserva { get; set; } = string.Empty;
        public Domain.Entities.Reserva.Clase TipoClase { get; set; }
        public int NumeroAsiento { get; set; }
        public Guid ClienteId { get; set; }
        public Guid VueloId { get; set; }

    }
}
