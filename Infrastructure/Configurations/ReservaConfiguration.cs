using FlightReservationAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace FlightReservationAPI.Infrastructure.Configurations
{
    public class ReservaConfiguration : IEntityTypeConfiguration<Reserva>
    {
        public void Configure(EntityTypeBuilder<Reserva> builder)
        {
            // Relación Reserva - Cliente
            builder.HasOne(r => r.Cliente)
                   .WithMany(c => c.Reservas)
                   .HasForeignKey(r => r.ClienteId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Relación Reserva - Vuelo
            builder.HasOne(r => r.Vuelo)
                   .WithMany()
                   .HasForeignKey(r => r.VueloId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
