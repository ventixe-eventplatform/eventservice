using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Data.Entities;

public class AddressEntity
{
    [Key]
    [Column(TypeName = "nvarchar(36)")]
    public string AddressId { get; set; } = Guid.NewGuid().ToString();

    [Column(TypeName = "nvarchar(50)")]
    public string Location { get; set; } = null!;

    [Column(TypeName = "nvarchar(30)")]
    public string City { get; set; } = null!;

    [Column(TypeName = "nvarchar(10)")]
    public string State { get; set; } = null!;
    public ICollection<EventEntity> Events { get; set; } = [];
}
