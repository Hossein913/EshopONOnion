using Microsoft.AspNetCore.Identity;

namespace EShop.Domain.Entity;

public class User : IdentityUser
{
    public string FullName { get; set; }
}
