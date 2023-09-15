//using Eshop.Domain.core.DataAccess.EfRipository;
//using Eshop.Domain.core.Dtos.Admin;
//using Eshop.Domain.core.Dtos.Authenticate;
//using Eshop.Domain.core.Dtos.Customer;
//using Eshop.Domain.core.Entities;
//using EShop.Domain.core.IServices.Authenticate;
//using EShop.Domain.IRepositories;

//using Microsoft.AspNetCore.Identity;

//using System.Data;

//namespace EShop.Data.Services.Authenticate
//{
//    public class AuthenticateService: IAuthenticateService
//    {
//        protected readonly IUserManagerRepository userRepository;
//        protected readonly ICustomerRepository customerRepository;
//        protected readonly IAdminRepository adminRepository;
//        protected readonly SignInManager<User> signInManager;
//        protected readonly UserManager<User> userManager;


//        public AuthenticateService(
//            SignInManager<User> signInManager,
//            UserManager<User> userManager,
//            IUserManagerRepository userRepository,
//            ICustomerRepository customerRepository,
//            IAdminRepository adminRepository)
//        {
//            this.signInManager = signInManager;
//            this.userManager = userManager;
//            this.userRepository = userRepository;
//            this.customerRepository = customerRepository;
//            this.adminRepository = adminRepository;
//        }


//        public async Task<IdentityResult?> RegisterService(UserRegisterDto registerModel, CancellationToken cancellationToken)
//        {
//            try
//            { 
                
//            }
//            catch (Exception ex)
//            {

//                //foreach (var error in ex.Errors)
//                //{
//                //    ModelState.AddModelError("", error.Description);
//                //}
//                //return View(model);
//            }

//        }

//        public async Task<IList<string>?> LoginService(UserLoginDto userLogin, CancellationToken cancellationToken)
//        {


//            return roles;

//        }
//    }
//}
