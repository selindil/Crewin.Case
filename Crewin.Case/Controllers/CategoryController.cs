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
            await _categoryService.GetCategoriesAsync();
            return View();
        }
    }
}
