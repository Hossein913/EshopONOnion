

namespace Eshop.Domain.core.Entities;

public partial class Picture
{
    //shadow properties should be null able becouse there is to gruop  1.Product photo   2.Category photo 
    public int Id { get; set; }

    public string? PictureLink { get; set; }

    public int? ProductId { get; set; }

    public int? CategoriId{ get; set; }

    public Product? Product { get; set; }

    public Category? Category { get; set; }


}
