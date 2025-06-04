using WebApi.Models;

namespace WebApi.Services;

public interface IEventService
{
    Task<EventModel?> GetEventAsync(string id);
    Task<IEnumerable<EventModel>> GetAllEventsAsync();
}
