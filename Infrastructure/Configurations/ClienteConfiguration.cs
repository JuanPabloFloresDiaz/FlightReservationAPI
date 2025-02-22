using FlightReservationAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace FlightReservationAPI.Infrastructure.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            // Relación Cliente - Ciudad (Ubicación del Cliente)
            builder.HasOne(c => c.Ciudad)
                   .WithMany(ci => ci.Clientes)
                   .HasForeignKey(c => c.CiudadId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Relación Cliente - País (Nacionalidad del Cliente)
            builder.HasOne(c => c.Nacionalidad)
                   .WithMany(p => p.Clientes)
                   .HasForeignKey(c => c.NacionalidadId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
