using FlightReservationAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
namespace FlightReservationAPI.Infrastructure.Configurations
{
    public class VueloRepository : IEntityTypeConfiguration<Vuelo>
    {
        public void Configure(EntityTypeBuilder<Vuelo> builder)
        {
            // Relación Vuelo - Destino
            builder.HasOne(v => v.Destino)
                   .WithMany(d => d.Vuelos)
                   .HasForeignKey(v => v.DestinoId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
