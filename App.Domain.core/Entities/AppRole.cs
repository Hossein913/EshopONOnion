using Microsoft.AspNetCore.Identity;

namespace Eshop.Domain.core.Entities;

public class AppRole : IdentityRole<int>
{
    public string Description { get; set; }
}
