
using Eshop.Domain.core.Dtos.Authenticate;
using Microsoft.AspNetCore.Identity;

namespace Eshop.Domain.core.DataAccess.EfRipository 
{ 
    public interface IUserManagerRepository
    {
        Task<int> Create(UserRegisterDto command, CancellationToken cancellationToken);
        Task<SignInResult> Login(UserLoginDto command, CancellationToken cancellationToken);
        //Task<List<ApplicationUserDto>> GetAll(CancellationToken cancellationToken);
    }
}
