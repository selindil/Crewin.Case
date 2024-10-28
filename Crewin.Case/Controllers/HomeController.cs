using Crewin.Case.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Crewin.Case.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        // ILogger, ASP.NET Core uygulamalarında loglama işlemlerini yönetmek için kullanılır. Bu kod sayesinde, HomeController içinde loglama yapılabilir; örneğin, hata oluştuğunda log kayıtlarına bilgi gönderilebilir.
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //Bu satır, hata sayfasına RequestId içeren bir ErrorViewModel nesnesi gönderir. RequestId, hatanın izlenmesine yardımcı olmak için kullanılan bir kimlik numarasıdır. 
    }
}
