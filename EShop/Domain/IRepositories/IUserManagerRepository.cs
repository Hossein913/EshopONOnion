using EShop.Domain.DTOs.Authenticate;
using Microsoft.AspNetCore.Identity;

namespace EShop.Domain.IRepositories
{
    public interface IUserManagerRepository
    {
        Task<int> Create(UserRegisterDto command, CancellationToken cancellationToken);
        Task<SignInResult> Login(UserLoginDto command, CancellationToken cancellationToken);
        //Task<List<ApplicationUserDto>> GetAll(CancellationToken cancellationToken);
    }
}
