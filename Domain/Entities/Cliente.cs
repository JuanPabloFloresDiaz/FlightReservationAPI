using FlightReservationAPI.Domain.Common;

namespace FlightReservationAPI.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;

        // Relaciones
        public ICollection<DetalleDocumentoCliente> Documentos { get; set; } = new List<DetalleDocumentoCliente>();
        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
    }
}
