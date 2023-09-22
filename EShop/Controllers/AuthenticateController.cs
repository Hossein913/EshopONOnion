

using Eshop.Domain.Entities;
using Eshop.Domain.Interfaces;
using EShop.ViewModels.Authenticate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Eshop
{
    public class AuthenticateController : Controller
    {

        protected readonly IUserManagerRepository userRepository;
        protected readonly IAdminRepository adminRepository;
        protected readonly ICustomerRepository customerRepository;
        protected readonly SignInManager<AppUser> signInManager;
        protected readonly UserManager<AppUser> userManager;
        public AuthenticateController(SignInManager<AppUser> signInManager, IUserManagerRepository userRepository, IAdminRepository adminRepository, UserManager<AppUser> userManager, ICustomerRepository customerRepository)
        {
            this.signInManager = signInManager;
            this.userRepository = userRepository;
            this.adminRepository = adminRepository;
            this.userManager = userManager;
            this.customerRepository = customerRepository;
        }


        [AllowAnonymous]
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel registerModel,CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
                return View(registerModel);

            try
            {

                    //UserRegisterDto registerUser = new UserRegisterDto
                    //{
                    //    Email = registerModel.Email,
                    //    Password = registerModel.Password,
                    //    IsAdmin = registerModel.IsAdmin
                    //};

                    //var UserId = await userRepository.Create(registerUser, cancellationToken);


                    //if (UserId != 0 && registerModel.IsAdmin)
                    //{

                    //    AdminAddDto adminDto = new AdminAddDto
                    //    {
                    //        Id = UserId,
                    //        FirstName = registerModel.FirstName,
                    //        LastName = registerModel.LastName,
                    //        Address = registerModel.Address
                    //    };
                    //    var Result = await adminRepository.Create(adminDto);
                    //    return RedirectToAction("Index", "Home");
                    //}
                    //else if (UserId != 0 && !registerModel.IsAdmin)
                    //{
                    //    CustomerAddDto customerDto = new CustomerAddDto
                    //    {
                    //        Id = UserId,
                    //        Name = registerModel.FirstName,
                    //        LastName = registerModel.LastName,
                    //        Address = registerModel.Address
                    //    };
                    //    var Result = await customerRepository.Create(customerDto);
                    //     return RedirectToAction("Index", "Home");

                    //}
                    //else
                    //{
                    //    return View();
                    //}

                     
                    
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }

            return View(registerModel);

        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel LoginModel, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
                return View(LoginModel);

            //UserLoginDto userLogin = new UserLoginDto
            //{
            //    Email = LoginModel.Email,
            //    Password = LoginModel.Password,
            //    IsPersistent = LoginModel.RememberMe
            //};

            //var result = await userRepository.Login(userLogin, cancellationToken);

            //IList<string> roles = null;
            //if (result.Succeeded)
            //{
            //    var user = await userManager.FindByNameAsync(userLogin.Email);
            //    roles = await userManager.GetRolesAsync(user);
            //}


            ////var result = await authenticate.Login(LoginModel);

            //if (result != null && roles.Contains("Admin"))
            //{
            //    return RedirectToAction("index", "Panel", new { area = "Admin"});
            //}
            //else if (result != null && roles.Contains("Customer"))
            //{
            //    return RedirectToAction("index", "Home");
            //}
            //else 
            //{ 
            //   return View(LoginModel);
            //}
            return View(LoginModel);

        }


        [HttpPost]
        public async Task<ActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }



    }
}
