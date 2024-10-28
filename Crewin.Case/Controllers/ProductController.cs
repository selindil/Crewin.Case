using Crewin.Case.Services;
using Microsoft.AspNetCore.Mvc;

namespace Crewin.Case.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        //IProductService, ProductController sınıfına bağımlılık olarak enjekte edilmiştir, böylece servis içerisindeki GetProductAsync metodunu kullanarak ürünleri veritabanından veya bir API'den alabilir.
        public async Task<IActionResult> Index(string? name)
        {
            var products = await _productService.GetProductAsync(name);
            return View(products);
        }
    }
}
//Bu sayfadaki kodlar, ProductController içinde ürünleri listelemek ve isteğe bağlı olarak ürün adına göre arama yapmak için gerekli işlemleri tanımlar ve Index görünümünde bu ürünlerin kullanıcıya sunulmasını sağlar.
