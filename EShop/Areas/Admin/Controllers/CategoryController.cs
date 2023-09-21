using Eshop.Domain.core.AppService;
using Eshop.Domain.core.Dtos.Category;
using Eshop.Domain.core.Entities;
using Eshop.Domain.core.IServices.FileService;
using EShop.Domain.AppServices.CategoryAppServce;
using EShop.Domain.core.IServices.CategoryService.Command;
using EShop.Domain.core.IServices.CategoryService.Queries;
using EShop.ViewModels.Category;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class CategoryController : Controller
    {
        protected readonly ICategoryQueryService _categoryQueryService;
        protected readonly ICategoryAppServices _categoryAppServices;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public CategoryController(
            ICategoryQueryService categoryQueryService,
            ICategoryCommandService categoryCommandService,
            IWebHostEnvironment hostingEnvironment,
            ICategoryAppServices categoryAppServices)
        {
            _categoryQueryService = categoryQueryService;
            _categoryAppServices = categoryAppServices;
            _hostingEnvironment = hostingEnvironment;

        }


        public async  Task<ActionResult> Index()
        {
            var categories = await _categoryQueryService.GetAllCategory();
            List<CategoryViewModel> categoryList = categories.Select(x => new CategoryViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Photo = x.Photo,
            }).ToList();
            return View(categoryList);
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
        public async Task<ActionResult> Create(CategoryViewModel Model)
        {
            if(!ModelState.IsValid)
                return  View(Model);

            if (Model.PhotoFile != null && Model.PhotoFile.Length > 0)
            {
                var wwwrootPath = _hostingEnvironment.WebRootPath;
                var uploadPath = Path.Combine(wwwrootPath, "uploads");

                CategoryAddDto categoryAddDto = new CategoryAddDto
                {
                     Name = Model.Name!,
                     Description = Model.Description!
                };

                await _categoryAppServices.CreateCategory(categoryAddDto, Model.PhotoFile, uploadPath);

                return View();
            }

            return View(Model);
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
