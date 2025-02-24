﻿using System.ComponentModel.DataAnnotations;
namespace FlightReservationAPI.Application.DTOs.Vuelo
{
    public class UpdateVueloDTO
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [StringLength(100)]
        public string NumeroVuelo { get; set; } = string.Empty;
        [Required]
        public DateTime FechaSalida { get; set; }
        [Required]
        public DateTime FechaLlegada { get; set; }
        [Required]
        public Guid DestinoId { get; set; }
    }
}
