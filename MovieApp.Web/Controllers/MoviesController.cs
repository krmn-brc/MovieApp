using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieApp.Web.Data;
using MovieApp.Web.Models;
using MovieApp.Web.Services.ToastrServices;

namespace MovieApp.Web.Controllers
{
  
    public class MoviesController: Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult List(int? id, string query)
        {
            var movies = MovieRepository.Movies;

            if(id != null)
            {
               movies = movies.Where(x => x.GenreId == id).ToList();
            } 
            if(!string.IsNullOrEmpty(query))
            {
                movies = movies.Where(x => x.Title.ToLower().Contains(query) || x.Description.ToLower().Contains(query)).ToList();
            }
           

            var viewModel = new MovieGenreViewModel()
            {
                Movies = movies
         
            };
            return View("Movies", viewModel);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {

            return View(MovieRepository.GetById(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Genres = new SelectList(GenreRepository.Genres, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if(ModelState.IsValid)
            {
                MovieRepository.Add(movie);
                return RedirectToAction("List");
            }
            ViewBag.Genres = new SelectList(GenreRepository.Genres, "Id", "Name");
            return View();
        }
       
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Genres = new SelectList(GenreRepository.Genres, "Id", "Name");
            return View(MovieRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if(ModelState.IsValid)
            {
                MovieRepository.Update(movie);
                return RedirectToAction("Details", "Movies", new {@id = movie.Id});
            }
            ViewBag.Genres = new SelectList(GenreRepository.Genres, "Id", "Name");
            return View(movie);
        }


        [HttpPost]
        public IActionResult Delete(int id, string Title)
        {
            MovieRepository.Delete(id);
            ToastrService.AddToQueue($"{Title} isimli film silindi", "Bilgilendirme", ToastrType.Warning);
            return RedirectToAction("List");
        }
    }
}