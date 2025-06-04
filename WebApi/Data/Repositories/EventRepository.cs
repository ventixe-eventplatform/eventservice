using Microsoft.EntityFrameworkCore;
using WebApi.Data.Entities;

namespace WebApi.Data.Repositories;

public class EventRepository(DataContext context) : IEventRepository
{
    private readonly DataContext _context = context;

    public async Task<EventEntity?> GetEventAsync(string id)
    {
        var entity = await _context.Events
            .Include(e => e.Address)
            .Include(e => e.Packages).FirstOrDefaultAsync(x => x.EventId == id);
        return entity;
    }

    public async Task<IEnumerable<EventEntity>> GetAllEventsAsync()
    {
        var entities = await _context.Events
            .Include(e => e.Address)
            .Include(e => e.Packages).ToListAsync();
        return entities;
    }
}
