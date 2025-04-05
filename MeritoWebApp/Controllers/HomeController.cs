using Microsoft.AspNetCore.Mvc;

namespace MeritoWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}