using EShop.Data;
using EShop.Domain.DTOs.Authenticate;
using EShop.Domain.Entity;
using EShop.Domain.IServices.CustomerService.Command;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EShop.Domain.IRepositories
{
    public class UserManagerRepository : IUserManagerRepository
    {
        protected readonly UserManager<User> _userManager;
        protected readonly RoleManager<Role> _RoleManager;
        protected readonly SignInManager<User> signInManager;
        protected readonly EshopContext _Context;

        public UserManagerRepository(UserManager<User> userManager, RoleManager<Role> roleManager, EshopContext eshopContext)
        {
            this._userManager = userManager;
            _RoleManager = roleManager;
            this._Context = eshopContext;
        }

        public async Task<int> Create(UserRegisterDto command, CancellationToken cancellationToken)
        {
             var user = new User { Email = command.Email, UserName = command.Email };
             var result = await _userManager.CreateAsync(user, command.Password);
            if (result.Succeeded)
            {
                Role role = new Role() { Name = "Customer", Description = "public registered Useres" };

                if (command.IsAdmin)
                {
                     role = new Role() { Name = "Admin", Description = "Super Admin" };
                }


                if (!await _RoleManager.RoleExistsAsync(role.Name))
                { 
                    await _RoleManager.CreateAsync(role);
                }

                    await _userManager.AddToRoleAsync(user, role.Name);
                    await _Context.SaveChangesAsync();
                    return user.Id;
            }
            return 0;

        }

        public async Task<SignInResult> Login(UserLoginDto command, CancellationToken cancellationToken)
        {
          var result = await signInManager.PasswordSignInAsync(command.Email, command.Password, command.IsPersistent, false);
            return result;
        }
    }
}
