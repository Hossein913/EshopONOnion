

namespace Eshop.Domain.core.Entities;

public partial class Picture
{
    public int Id { get; set; }

    public string? LinsAddress { get; set; }

    public int ProductId { get; set; }
    public int CategoriId{ get; set; }

    public Product Product { get; set; }

    public Category Category { get; set; }


}
