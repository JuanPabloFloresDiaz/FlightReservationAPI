using FlightReservationAPI.Domain.Interfaces;
using FlightReservationAPI.Domain.Entities;
using FlightReservationAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FlightReservationAPI.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;

        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Cliente cliente)
        {
            _context.GetDbSet<Cliente>().Add(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var cliente = await _context.GetDbSet<Cliente>().FindAsync(id);
            if (cliente != null)
            {
                cliente.DeletedAt = DateTime.UtcNow;
                _context.GetDbSet<Cliente>().Update(cliente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            return await _context.GetDbSet<Cliente>()
                .Where(c => c.DeletedAt == null)
                .ToListAsync();
        }

        public async Task<Cliente?> GetByIdAsync(Guid id)
        {
            return await _context.GetDbSet<Cliente>()
                .Where(c => c.DeletedAt == null)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task UpdateAsync(Cliente cliente)
        {
            _context.GetDbSet<Cliente>().Update(cliente);
            await _context.SaveChangesAsync();
        }
    }
}
