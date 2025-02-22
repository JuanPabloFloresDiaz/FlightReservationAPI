using FlightReservationAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace FlightReservationAPI.Infrastructure.Configurations
{
    public class DestinoConfiguration : IEntityTypeConfiguration<Destino>
    {
        public void Configure(EntityTypeBuilder<Destino> builder)
        {
            // Relación Destino - Ciudad
            builder.HasOne(d => d.Ciudad)
                   .WithMany(c => c.Destinos)
                   .HasForeignKey(d => d.CiudadId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
