

using Eshop.Domain.core.Dtos.Authenticate;
using Microsoft.AspNetCore.Identity;

namespace EShop.Domain.core.IServices.Authenticate
{
    public interface IAuthenticateService
    {
        Task<IdentityResult?> RegisterService(UserRegisterDto registerModel, CancellationToken cancellationToken);
        Task<IList<string>?> LoginService(UserLoginDto LoginModel, CancellationToken cancellationToken);
    }
}
