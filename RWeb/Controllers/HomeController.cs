using Microsoft.AspNetCore.Mvc;

namespace RWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
