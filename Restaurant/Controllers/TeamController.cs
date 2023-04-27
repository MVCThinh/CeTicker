using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
