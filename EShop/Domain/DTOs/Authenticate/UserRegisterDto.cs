using System.ComponentModel.DataAnnotations;

namespace EShop.Domain.DTOs.Authenticate
{
    public class UserRegisterDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public bool IsAdmin { get; set; }= false;


    }
}
