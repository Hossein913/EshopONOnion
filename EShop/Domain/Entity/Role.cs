using Microsoft.AspNetCore.Identity;

namespace EShop.Domain.Entity;

public class Role : IdentityRole<int>
{
    public string Description { get; set; }
}
