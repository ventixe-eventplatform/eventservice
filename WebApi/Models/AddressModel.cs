namespace WebApi.Models;

public class AddressModel
{
    public string Location { get; set; } = null!;
    public string City { get; set; } = null!;
    public string State { get; set; } = null!;
    public List<EventModel> Events { get; set; } = [];
}
