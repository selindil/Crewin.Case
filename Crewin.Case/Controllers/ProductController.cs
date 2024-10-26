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

        public IActionResult Index()
        {
            var q = _productService.GetProductAsync();
            return View();
        }
    }
}
