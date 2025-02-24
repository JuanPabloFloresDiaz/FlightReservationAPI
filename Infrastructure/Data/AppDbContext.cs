using FlightReservationAPI.Domain.Entities;
using FlightReservationAPI.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FlightReservationAPI.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Agregar las entidades
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // Registrar automáticamente DbSet para todas las entidades que hereden de BaseEntity
            RegisterDbSets();
        }

        private void RegisterDbSets()
        {
            var entityTypes = Assembly.GetExecutingAssembly()
                                      .GetTypes()
                                      .Where(t => t.IsClass && !t.IsAbstract && typeof(BaseEntity).IsAssignableFrom(t));

            foreach (var entityType in entityTypes)
            {
                var dbSetType = typeof(DbSet<>).MakeGenericType(entityType);
                GetType().GetProperty(entityType.Name)?.SetValue(this, dbSetType);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aplica automáticamente todas las configuraciones de IEntityTypeConfiguration
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
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
