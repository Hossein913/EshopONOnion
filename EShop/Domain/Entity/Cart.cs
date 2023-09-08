using System;
using System.Collections.Generic;

namespace EShop.Domain.Entity;

public partial class Cart
{
    public int Id { get; set; }

    public int? Quntity { get; set; }

    public int CustomerId { get; set; }

    public bool? IsPaied { get; set; }

    public bool IsDeleted { get; set; } = false;

    public virtual Customer? Customer { get; set; }
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
