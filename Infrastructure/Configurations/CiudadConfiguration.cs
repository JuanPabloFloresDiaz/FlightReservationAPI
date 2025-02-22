using FlightReservationAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace FlightReservationAPI.Infrastructure.Configurations
{
    public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(EntityTypeBuilder<Ciudad> builder)
        {
            // Relación Ciudad - País
            builder.HasOne(c => c.Pais)
                   .WithMany(p => p.Ciudades)
                   .HasForeignKey(c => c.PaisId)
                   .OnDelete(DeleteBehavior.Restrict); // Evita eliminación en cascada
        }

    }
}