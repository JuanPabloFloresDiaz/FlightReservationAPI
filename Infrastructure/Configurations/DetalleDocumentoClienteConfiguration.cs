using FlightReservationAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace FlightReservationAPI.Infrastructure.Configurations
{
    public class DetalleDocumentoClienteConfiguration : IEntityTypeConfiguration<DetalleDocumentoCliente>
    {
        public void Configure(EntityTypeBuilder<DetalleDocumentoCliente> builder)
        {
            // Relación Cliente - DetalleDocumentoCliente
            builder.HasOne(d => d.Cliente)
                   .WithMany(c => c.Documentos)
                   .HasForeignKey(d => d.ClienteId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Relación DetalleDocumentoCliente - Documento
            builder.HasOne(d => d.Documento)
                   .WithMany()
                   .HasForeignKey(d => d.DocumentoId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
