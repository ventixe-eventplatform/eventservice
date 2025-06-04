using WebApi.Data;

namespace WebApi.Models;

public class EventModel
{
    public string EventId { get; set; } = null!;
    public string? EventImage { get; set; }
    public string EventName { get; set; } = null!;
    public string? EventDescription { get; set; }
    public string? EventType { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string AddressId { get; set; } = null!;
    public AddressModel Address { get; set; } = null!;
    public IEnumerable<PackageModel> Packages { get; set; } = new List<PackageModel>();
}
