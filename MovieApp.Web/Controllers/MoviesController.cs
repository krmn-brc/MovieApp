using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieApp.Web.Data;
using MovieApp.Web.Entities;
using MovieApp.Web.Models;
using MovieApp.Web.Services.ToastrServices;

namespace MovieApp.Web.Controllers
{
  
    public class MoviesController: Controller
    {
        private readonly MovieDbContext _context;

        public MoviesController(MovieDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult List(int? id, string query)
        {
            var movies = _context.Movies.AsQueryable();

            if(id != null)
            {
               movies = movies.Where(x => x.GenreId == id);
            } 
            if(!string.IsNullOrEmpty(query))
            {
                movies = movies.Where(x => x.Title.ToLower().Contains(query) || x.Description.ToLower().Contains(query));
            }
           

            var viewModel = new MovieGenreViewModel()
            {
                Movies = movies.ToList()
         
            };
            return View("Movies", viewModel);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {

            return View(_context.Movies.Find(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if(ModelState.IsValid)
            {
                // MovieRepository.Add(movie);
                _context.Movies.Add(movie);
                _context.SaveChanges();
                ToastrService.AddToQueue($"Yeni bir film eklendi", "Bilgilendirme", ToastrType.Success);

                return RedirectToAction("List");
            }
            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "Id", "Name");
            return View();
        }
       
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "Id", "Name");
            return View(_context.Movies.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if(ModelState.IsValid)
            {
                
                ToastrService.AddToQueue($"{movie.Title} isimli film güncelleniyor", "Bilgilendirme", ToastrType.Warning);
                // MovieRepository.Update(movie);
                _context.Movies.Update(movie);
                _context.SaveChanges();
                ToastrService.AddToQueue($"{movie.Title} isimli film güncellendi", "Bilgilendirme", ToastrType.Success);
                return RedirectToAction("Details", "Movies", new {@id = movie.Id});
                
            }
            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "Id", "Name");
            return View(movie);
        }


        [HttpPost]
        public IActionResult Delete(int id, string Title)
        {
            // MovieRepository.Delete(id);
            var entity = _context.Movies.Find(id);
            _context.Movies.Remove(entity);
            _context.SaveChanges();
            ToastrService.AddToQueue($"{Title} isimli film silindi", "Bilgilendirme", ToastrType.Warning);
            return RedirectToAction("List");
        }
    }
}