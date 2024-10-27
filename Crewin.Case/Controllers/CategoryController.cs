using Crewin.Case.Services;
using Microsoft.AspNetCore.Mvc;

namespace Crewin.Case.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetList();
            //await _categoryService.GetCategoriesAsync();
            return View(categories);
        }

        /// <summary>
        /// apiden categoryleri ceker. database yazar :   url https://localhost:7154/category/CreateCategory 
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> CreateCategory()
        {
             await _categoryService.GetCategoriesAsync();
            return View();
        }
    }
}
