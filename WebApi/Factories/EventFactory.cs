using WebApi.Data.Entities;
using WebApi.Models;

namespace WebApi.Factories;

public static class EventFactory
{
    public static EventModel Create(EventEntity entity)
    {
        return new EventModel
        {
            EventId = entity.EventId,
            EventImage = entity.EventImage,
            EventName = entity.EventName,
            EventDescription = entity.EventDescription,
            EventType = entity.EventType,
            StartDate = entity.StartDate,
            EndDate = entity.EndDate,
            Address = new AddressModel
            {
                Location = entity.Address.Location,
                City = entity.Address.City,
                State = entity.Address.State,
            },
            Packages = entity.Packages.Select(x => new PackageModel
            {
                PackageId = x.PackageId,
                PackageType = x.PackageType,
                Seating = x.Seating,
                ViewType = x.ViewType,
                Price = x.Price,
                Quantity = x.Quantity,
            }).ToList()
        };
    }
}
