
using Eshop.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Eshop.Domain.Interfaces
{
    public interface IUserManagerRepository
    {
        Task<int> Create(AppUser command, CancellationToken cancellationToken);
        Task<SignInResult> Login(AppUser command, CancellationToken cancellationToken);
        //Task<List<ApplicationUserDto>> GetAll(CancellationToken cancellationToken);
    }
}
