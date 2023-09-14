using System.ComponentModel.DataAnnotations;

namespace EShop.Domain.DTOs.Authenticate
{
    public class UserLoginDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public bool IsPersistent { get; set; }= false;


    }       
}