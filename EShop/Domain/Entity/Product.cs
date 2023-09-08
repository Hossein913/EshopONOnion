using System;
using System.Collections.Generic;

namespace EShop.Domain.Entity;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public int CategoryId { get; set; }

    public int? Quntity { get; set; }

    public bool IsDeleted { get; set; } = false;

    public virtual ICollection<Picture> Pictures { get; set; } = new List<Picture>();
    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();
    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
}
