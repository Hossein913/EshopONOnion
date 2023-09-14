using EShop.Domain.DTOs.Authenticate;
using EShop.Domain.DTOs.Customer;
using EShop.Domain.Entity;
using EShop.Domain.IRepositories;
using EShop.Domain.IServices.Authenticate;
using EShop.Domain.IServices.CustomerService.Command;
using Microsoft.AspNetCore.Identity;
using ProductManager_quiz_.Models.ViewModels;

namespace EShop.Data.Services.Authenticate
{
    public class AuthenticateService: IAuthenticateService
    {
        protected readonly IUserManagerRepository userRepository;
        protected readonly ICustomerRepository customerRepository;
        protected readonly IAdminRepository adminRepository;
        protected readonly SignInManager<User> signInManager;
        protected readonly UserManager<User> userManager;


        public AuthenticateService(
            SignInManager<User> signInManager,
            IUserManagerRepository userRepository,
            ICustomerRepository customerRepository,
            IAdminRepository adminRepository,
            UserManager<User> userManager)
        {
            this.signInManager = signInManager;
            this.userRepository = userRepository;
            this.customerRepository = customerRepository;
            this.adminRepository = adminRepository;
            this.userManager = userManager;
        }


        public async Task<IdentityResult?> RegisterService(RegisterViewModel registerModel, CancellationToken cancellationToken)
        {
            try
            {

                 UserRegisterDto registerUser = new UserRegisterDto { 
                     Email = registerModel.Email,
                     Password = registerModel.Password,
                     IsAdmin= registerModel.IsAdmin
                 };

                 var UserId = await userRepository.Create(registerUser, cancellationToken);

                if (UserId != 0 && registerModel.IsAdmin)
                {

                    AdminAddDto adminDto = new AdminAddDto
                    {
                        Id = UserId,
                        FirstName = registerModel.FirstName,
                        LastName = registerModel.LastName,
                        Address = registerModel.Address
                    };
                    var Result = await adminRepository.Create(adminDto);

                }
                else if (UserId != 0 && !registerModel.IsAdmin)
                {
                    CustomerAddDto customerDto = new CustomerAddDto
                    {
                        Id = UserId,
                        Name = registerModel.FirstName,
                        LastName = registerModel.LastName,
                        Address = registerModel.Address
                    };
                    var Result = await customerRepository.Create(customerDto);


                }
                return IdentityResult.Success;
            }
            catch (Exception ex)
            {

                throw new Exception();
            }

        }

        public async Task<SignInResult?> LoginService(LoginViewModel LoginModel, CancellationToken cancellationToken)
        {
            UserLoginDto userLogin = new UserLoginDto
            {
                Email = LoginModel.Email,
                Password = LoginModel.Password,
                IsPersistent = LoginModel.RememberMe
            };
            var result = await userRepository.Login(userLogin, cancellationToken);

            if (result.Succeeded)
            {
               

            }
            return result;
        }
    }
}
