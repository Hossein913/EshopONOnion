
using EShop.ViewModels.Category;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;



        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            //var categories = await _service.GetAllCategory();
            //List<CategoryViewModel> categoryView = categories.Select(x => new CategoryViewModel {
            //    Id = x.Id,
            //    Name = x.Name,
            //    Description = x.Description,
            //    Photo = x.Photo
            //}).ToList();

            return View();


        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}