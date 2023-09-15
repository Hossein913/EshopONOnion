using EShop.Domain.core.IServices.CategoryService.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryQueryService _service;


        public HomeController(ILogger<HomeController> logger, ICategoryQueryService service )
        {
            _logger = logger;
            _service = service;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var categories = await _service.GetAllCategory();
            return View(categories);
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}