using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
