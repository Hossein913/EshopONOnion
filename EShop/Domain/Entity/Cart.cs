using System;
using System.Collections.Generic;

namespace EShop.Domain.Entity;

public partial class Cart
{
    public int Id { get; set; }

    public bool? IsPaied { get; set; }

    public bool IsDeleted { get; set; } = false;

    public int CustomerId { get; set; }

    public Customer Customers { get; set; }
    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
