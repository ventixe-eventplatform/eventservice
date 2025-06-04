using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Data.Entities;

public class PackageEntity
{
    [Key]
    [Column(TypeName = "nvarchar(36)")]
    public string PackageId { get; set; } = Guid.NewGuid().ToString();

    [Column(TypeName = "nvarchar(50)")]
    public string PackageType { get; set; } = null!;

    public SeatingType Seating{ get; set; }

    [Column(TypeName = "nvarchar(20)")]
    public string? ViewType { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    public int? Quantity { get; set; }

    public string EventId { get; set; } = null!;
    [ForeignKey(nameof(EventId))]
    public EventEntity Event { get; set; } = null!;

}
