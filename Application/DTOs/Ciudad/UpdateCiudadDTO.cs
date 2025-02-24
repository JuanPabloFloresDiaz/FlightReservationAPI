using System.ComponentModel.DataAnnotations;

namespace FlightReservationAPI.Application.DTOs.Ciudad
{
    public class UpdateCiudadDTO
    {
        public Guid Id { get; set; }

        [StringLength(50)]
        public string? Nombre { get; set; }

        [StringLength(10)]
        public string? CodigoPostal { get; set; }

        public Guid? PaisId { get; set; }
    }
}