using EShop.Data;
using EShop.Domain.Entity;
using EShop.Domain.IServices.Authenticate;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProductManager_quiz_.Models.ViewModels;
using System.Threading;

namespace ProductManager_quiz_.Controllers
{
    public class AuthenticateController : Controller
    {
        protected readonly IAuthenticateService authenticateService;
        protected readonly SignInManager<User> signInManager;

        public AuthenticateController(IAuthenticateService authenticationServices,SignInManager<User> signInManager)
        {
            authenticateService = authenticationServices;
            this.signInManager = signInManager;
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
            if (ModelState.IsValid)
            {

                try
                {

                    var result = await authenticateService.RegisterService(registerModel, cancellationToken);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        foreach (var err in result.Errors)
                        {
                            ModelState.AddModelError("", err.Description);
                        }
                        return View(registerModel);
                    }

                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return View();
                }
            }
            else { return View(registerModel); }
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
        public async Task<ActionResult> Login(LoginViewModel LoginModel)
        {
            if (!ModelState.IsValid)
                return View(LoginModel);

            var result = authenticateService.LoginService(LoginModel), cancellationToken)



            var result = await authenticate.LogIn(LoginModel);

            if (result.Succeeded)
            {
                return RedirectToAction("index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Invalid SignIn attempt");
                return View(LoginModel);
            }
        }


        [HttpPost]
        public async Task<ActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }



    }
}
