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

        public async Task<IActionResult> Index(string? name)
        {
            var products = await _productService.GetProductAsync(name);
            return View(products);
        }
    }
}
