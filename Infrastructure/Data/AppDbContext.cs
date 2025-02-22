using FlightReservationAPI.Domain.Entities;
using FlightReservationAPI.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace FlightReservationAPI.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Agregar las entidades
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<TipoDocumento> TiposDocumentos { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<DetalleDocumentoCliente> DetallesDocumentosClientes { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Vuelo> Vuelos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Definir relaciones entre entidades
            modelBuilder.Entity<Ciudad>()
                .HasOne(c => c.Pais)
                .WithMany(p => p.Ciudades)
                .HasForeignKey(c => c.PaisId);

            modelBuilder.Entity<Destino>()
                .HasOne(d => d.Ciudad)
                .WithMany(c => c.Destinos)
                .HasForeignKey(d => d.CiudadId);

            modelBuilder.Entity<Vuelo>()
                .HasOne(v => v.Destino)
                .WithMany(d => d.Vuelos)
                .HasForeignKey(v => v.DestinoId);

            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.Cliente)
                .WithMany(c => c.Reservas)
                .HasForeignKey(r => r.ClienteId);

            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.Vuelo)
                .WithMany()
                .HasForeignKey(r => r.VueloId);

            modelBuilder.Entity<Documento>()
                .HasOne(d => d.TipoDocumento)
                .WithMany(t => t.Documentos)
                .HasForeignKey(d => d.TipoDocumentoId);
            
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedAt = DateTime.UtcNow;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedAt = DateTime.UtcNow;
                }
            }
            return base.SaveChanges();
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedAt = DateTime.UtcNow;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedAt = DateTime.UtcNow;
                }
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
