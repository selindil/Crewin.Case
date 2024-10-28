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
//CategoryController sınıfı, Category (kategori) nesneleriyle ilgili işlemleri kontrol eder.
//Index metodu, kategoriler listesini almak ve bunu kullanıcıya göstermek için yazılmıştır.
//CreateCategory metodu ise kategorileri bir API'den çeker ve veritabanına yazar. Bu metodun bir URL açıklaması var, böylece https://localhost:7154/category/CreateCategory adresine yapılan istekler bu metot tarafından işlenir.
// Kısaca bu kodlar, Category nesneleri üzerinde veri listeleme ve veritabanına kaydetme işlemlerini, kullanıcı isteklerine göre yönetir.