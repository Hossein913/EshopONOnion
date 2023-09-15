using EShop.Domain.DTOs.Authenticate;
using Microsoft.AspNetCore.Identity;
using ProductManager_quiz_.Models.ViewModels;

namespace EShop.Domain.IServices.Authenticate
{
    public interface IAuthenticateService
    {
        Task<IdentityResult?> RegisterService(RegisterViewModel registerModel, CancellationToken cancellationToken);
        Task<SignInResult?> LoginService(UserLoginDto LoginModel, CancellationToken cancellationToken);
    }
}
