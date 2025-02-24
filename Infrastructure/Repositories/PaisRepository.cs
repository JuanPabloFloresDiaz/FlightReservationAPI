using FlightReservationAPI.Domain.Entities;
using FlightReservationAPI.Domain.Interfaces;
using FlightReservationAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FlightReservationAPI.Infrastructure.Repositories
{
    public class PaisRepository : IPaisRepository
    {
        private readonly AppDbContext _context;

        public PaisRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Pais pais)
        {
            _context.GetDbSet<Pais>().Add(pais);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var pais = await _context.GetDbSet<Pais>().FindAsync(id);
            if (pais != null)
            {
                pais.DeletedAt = DateTime.UtcNow;
                _context.GetDbSet<Pais>().Update(pais);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Pais>> GetAllAsync()
        {
            return await _context.GetDbSet<Pais>()
                .Where(p => p.DeletedAt == null)
                .ToListAsync();
        }

        public async Task<Pais?> GetByIdAsync(Guid id)
        {
            return await _context.GetDbSet<Pais>()
                .Where(p => p.DeletedAt == null)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdateAsync(Pais pais)
        {
            _context.GetDbSet<Pais>().Update(pais);
            await _context.SaveChangesAsync();
        }
    }
}