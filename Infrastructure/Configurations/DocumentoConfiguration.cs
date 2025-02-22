using FlightReservationAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace FlightReservationAPI.Infrastructure.Configurations
{
    public class DocumentoConfiguration : IEntityTypeConfiguration<Documento>
    {
        public void Configure(EntityTypeBuilder<Documento> builder)
        {
            // Relación Documento - TipoDocumento
            builder.HasOne(d => d.TipoDocumento)
                   .WithMany(t => t.Documentos)
                   .HasForeignKey(d => d.TipoDocumentoId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
