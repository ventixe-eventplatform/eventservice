using WebApi.Data.Entities;

namespace WebApi.Data.Repositories;

public interface IEventRepository
{
    Task<EventEntity?> GetEventAsync(string id);
    Task<IEnumerable<EventEntity>> GetAllEventsAsync();
}
