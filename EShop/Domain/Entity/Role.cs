using Microsoft.AspNetCore.Identity;

namespace EShop.Domain.Entity;

public class Role : IdentityRole
{
    public string Description { get; set; }
}
