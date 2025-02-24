namespace FlightReservationAPI.Application.DTOs.Documento
{
    public class DocumentoDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nombre { get; set; } = string.Empty;
        public Guid TipoDocumentoId { get; set; }
    }
}
