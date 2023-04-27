using _1.eTickers.Data;
using Microsoft.AspNetCore.Mvc;

namespace _1.eTickers.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;

        public ProducersController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var allProducers = _context.Producers.ToList();
            return View(allProducers);
        }
    }
}
