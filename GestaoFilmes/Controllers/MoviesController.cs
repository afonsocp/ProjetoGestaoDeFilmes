using Microsoft.AspNetCore.Mvc;
using GestaoFilmes.Models;
using System.Collections.Generic;
using System.Linq;

namespace GestaoFilmes.Controllers
{
    public class MoviesController : Controller
    {
        private static List<Movie> _movies = new List<Movie>();
        private static int _nextId = 1;

        public IActionResult Index()
        {
            return View(_movies);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                movie.Id = _nextId++;
                _movies.Add(movie);
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        public IActionResult Edit(int id)
        {
            var movie = _movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var index = _movies.FindIndex(m => m.Id == id);
                _movies[index] = movie;
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        public IActionResult Delete(int id)
        {
            var movie = _movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var movie = _movies.FirstOrDefault(m => m.Id == id);
            if (movie != null)
            {
                _movies.Remove(movie);
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Search(string searchString, MovieGenre? genre)
        {
            var movies = _movies.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(m => m.Title.Contains(searchString));
            }

            if (genre.HasValue)
            {
                movies = movies.Where(m => m.Genre == genre.Value);
            }

            return View("Index", movies.ToList());
        }
    }
}