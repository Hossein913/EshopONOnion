

namespace Eshop.Domain.core.Entities;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public int? Quntity { get; set; }

    public bool IsDeleted { get; set; } = false;
    public int CategoryId { get; set; }

    public ICollection<Picture> Pictures { get; set; } = new List<Picture>();
    public Order? Order { get; set; }
    public Category Categories { get; set; } = new Category();
}
