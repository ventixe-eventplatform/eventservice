using WebApi.Data;

namespace WebApi.Models;

public class PackageModel
{
    public string PackageId { get; set; } = null!;
    public string PackageType { get; set; } = null!;
    public SeatingType Seating { get; set; }
    public string? ViewType { get; set; }
    public decimal Price { get; set; }
    public int? Quantity { get; set; }
    public string EventId { get; set; } = null!;
    public EventModel Event { get; set; } = null!;
}
