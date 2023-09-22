﻿

using Eshop.Domain.Entities;
using Eshop.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Eshop.Infrastructure.Repositories
{
    public class UserManagerRepository : IUserManagerRepository
    {
        protected readonly UserManager<AppUser> _userManager;
        protected readonly RoleManager<AppRole> _RoleManager;
        protected readonly SignInManager<AppUser> signInManager;
        protected readonly EshopContext _Context;

        public UserManagerRepository(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, EshopContext eshopContext, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _RoleManager = roleManager;
            _Context = eshopContext;
            this.signInManager = signInManager;
        }

        public async Task<int> Create(AppUser command, CancellationToken cancellationToken)
        {
            var user = new AppUser { Email = command.Email, UserName = command.Email };
            var result = await _userManager.CreateAsync(user, command.PasswordHash);
            if (result.Succeeded)
            {
                AppRole role = new AppRole() { Name = "Customer", Description = "public registered Useres" };

                //if (command)
                //{
                //    role = new AppRole() { Name = "Admin", Description = "Super Admin" };
                //}


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

        public async Task<SignInResult> Login(AppUser command, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByNameAsync(command.Email);
            var result = await signInManager.PasswordSignInAsync(user, command.PasswordHash, false, true);
            return result;
        }
    }
}
