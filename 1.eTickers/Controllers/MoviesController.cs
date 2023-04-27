using _1.eTickers.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _1.eTickers.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var allMovies = _context.Movies.Include(n => n.Cinema).ToList();
            return View(allMovies);
        }
    }
}
