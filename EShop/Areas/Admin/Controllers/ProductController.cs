using EShop.ViewModels;
using EShop.ViewModels.Category;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ProductController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public ProductController(
            IWebHostEnvironment hostingEnvironment )
        {
            _hostingEnvironment = hostingEnvironment;
        }



        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel Model)
        {

            //if (!ModelState.IsValid)
            //    return View(Model);

            //if (Model.PhotoFile != null && Model.PhotoFile.Length > 0)
            //{
            //    var wwwrootPath = _hostingEnvironment.WebRootPath;
            //    var uploadPath = Path.Combine(wwwrootPath, "uploads");

            //    CategoryAddDto categoryAddDto = new CategoryAddDto
            //    {
            //        Name = Model.Name!,
            //        Description = Model.Description!
            //    };

            //    //await _categoryAppServices.CreateCategory(categoryAddDto, Model.PhotoFile, uploadPath);

            //    return View();
            //}

            return View(Model);




            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
