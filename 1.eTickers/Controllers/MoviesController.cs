using _1.eTickers.Data;
using _1.eTickers.Data.Services;
using _1.eTickers.Data.Static;
using _1.eTickers.Data.ViewModels;
using _1.eTickers.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace _1.eTickers.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class MoviesController : Controller
    {
        private readonly IMoviesService _services;


        public MoviesController(IMoviesService services)
        {
            _services = services;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allMovies = await _services.GetAllAsync(n => n.Cinema);
            return View(allMovies);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchString)
        {
            var allMovies = await _services.GetAllAsync(n => n.Cinema);

            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResultNew = allMovies.Where(n => string.Equals(n.Name,searchString, StringComparison.CurrentCultureIgnoreCase) ||
                string.Equals(n.Description, searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();

                return View("Index", filteredResultNew);
            }
            return View("Index", allMovies);
        }

        // Get: Movies/Details
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _services.GetMovieByIdAsync(id);
            return View(movieDetail);
        }

        // Get: Movies/Create
        public async Task<IActionResult> Create()
        {
            var movieDropdownsData = await _services.GetNewMovieDropdownsValues();

            ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "Name");
            ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewMovieVM movie)
        {
            if (!ModelState.IsValid)
            {
                var movieDropdownsData = await _services.GetNewMovieDropdownsValues();

                ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
                ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "Name");
                ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "Name");

                return View(movie);
            }

            await _services.AddNewMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }

        // Get: Movies/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var movieDetails = await _services.GetMovieByIdAsync(id);
            if (movieDetails == null) return View("Notfound");

            var response = new NewMovieVM()
            {
                Id = movieDetails.Id,
                Name = movieDetails.Name,
                Description = movieDetails.Description,
                Price = movieDetails.Price,
                StartDate = movieDetails.StartDate,
                EndDate = movieDetails.EndDate,
                ImageURL = movieDetails.ImageURl,
                MovieCategory = movieDetails.MovieCategory,
                CinemaId = movieDetails.CinemaId,
                ProducerId = movieDetails.ProducerId,
                ActorIds = movieDetails.Actors_Movies.Select(n => n.ActorId).ToList(),
            };

            var movieDropdownsData = await _services.GetNewMovieDropdownsValues();

            ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "Name");
            ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "Name");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewMovieVM movie)
        {
            if (id != movie.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var movieDropdownsData = await _services.GetNewMovieDropdownsValues();

                ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
                ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "Name");
                ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "Name");

                return View(movie);
            }

            await _services.UpdateMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }

    }
}
