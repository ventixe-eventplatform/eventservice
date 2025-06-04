using WebApi.Data.Repositories;
using WebApi.Factories;
using WebApi.Models;

namespace WebApi.Services;

public class EventService(IEventRepository eventRepository) : IEventService
{
    private readonly IEventRepository _eventRepository = eventRepository;

    #region Read
    public async Task<EventModel?> GetEventAsync(string id)
    {
        var entity = await _eventRepository.GetEventAsync(id);
        return EventFactory.Create(entity);
    }

    public async Task<IEnumerable<EventModel>> GetAllEventsAsync()
    {
        var entities = await _eventRepository.GetAllEventsAsync();
        return entities.Select(EventFactory.Create).ToList();
    }
    #endregion
}
