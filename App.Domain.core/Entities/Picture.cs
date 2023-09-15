

namespace Eshop.Domain.core.Entities;

public partial class Picture
{
    public int Id { get; set; }

    public string? LinsAddress { get; set; }

    public int? ProductId { get; set; }

    public virtual Product? Product { get; set; }
}
