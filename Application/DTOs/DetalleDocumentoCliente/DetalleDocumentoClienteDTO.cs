namespace FlightReservationAPI.Application.DTOs.DetalleDocumentoCliente
{
    public class DetalleDocumentoClienteDTO
    {
        public Guid Id { get; set; }
        public string Valor { get; set; } = string.Empty;
        public Guid DocumentoId { get; set; }
        public Guid ClienteId { get; set; }


    }
}
