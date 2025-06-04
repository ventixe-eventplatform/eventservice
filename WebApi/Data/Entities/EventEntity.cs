using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Data.Entities;

public class EventEntity
{
    [Key]
    [Column(TypeName = "nvarchar(36)")]
    public string EventId { get; set; } = Guid.NewGuid().ToString();

    public string? EventImage { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    public string EventName { get; set; } = null!;

    [Column(TypeName = "nvarchar(max)")]
    public string? EventDescription { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    public string? EventType { get; set; }

    [Column(TypeName = "datetime2")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime2")]
    public DateTime? EndDate { get; set; }
    public string AddressId { get; set; } = null!;
    [ForeignKey(nameof(AddressId))]
    public AddressEntity Address { get; set; } = null!;

    public ICollection<PackageEntity> Packages { get; set; } = new List<PackageEntity>();
}
