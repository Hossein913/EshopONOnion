using Microsoft.AspNetCore.Identity;

namespace Eshop.Domain.core.Entities;

public class Role : IdentityRole<int>
{
    public string Description { get; set; }
}
