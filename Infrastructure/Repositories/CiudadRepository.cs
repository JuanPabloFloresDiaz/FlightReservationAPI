using FlightReservationAPI.Domain.Entities;
using FlightReservationAPI.Domain.Interfaces;
using FlightReservationAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FlightReservationAPI.Infrastructure.Repositories
{
    public class CiudadRepository : ICiudadRepository
    {
        private readonly AppDbContext _context;

        public CiudadRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Ciudad ciudad)
        {
            _context.GetDbSet<Ciudad>().Add(ciudad);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var ciudad = await _context.GetDbSet<Ciudad>().FindAsync(id);
            if (ciudad != null)
            {
                ciudad.DeletedAt = DateTime.UtcNow;
                _context.GetDbSet<Ciudad>().Update(ciudad);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Ciudad>> GetAllAsync()
        {
            return await _context.GetDbSet<Ciudad>()
                .Where(c => c.DeletedAt == null)
                .ToListAsync();
        }

        public async Task<Ciudad?> GetByIdAsync(Guid id)
        {
            return await _context.GetDbSet<Ciudad>()
                .Where(c => c.DeletedAt == null)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task UpdateAsync(Ciudad ciudad)
        {
            _context.GetDbSet<Ciudad>().Update(ciudad);
            await _context.SaveChangesAsync();
        }
    }
}