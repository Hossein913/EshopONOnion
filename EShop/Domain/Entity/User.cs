using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EShop.Domain.Entity;

public class User : IdentityUser
{
    [Key]
    public string Id { get; set; }
    public string FullName { get; set; }
}
