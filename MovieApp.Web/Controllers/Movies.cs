using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;

namespace MovieApp.Web.Controllers
{
    [Route("[controller]")]
    public class Movies : Controller
    {
       
        public IActionResult Index()
        {
            List<Movie> movies = new()
        {
            new()
            {
                Id = 1,
                Title = "Film 1",
                Description = "Film 1 Açıklama",
                Director = "Film 1 Yönetmeni",
                Players = new[] {"1. Oyuncu", "2. Oyuncu", "3. Oyuncu"},
                ImageUrl = "1.jpg"
            },
            new()
            {
                Id = 2,
                Title = "Film 2",
                Description = "Film 2 Açıklama",
                Director = "Film 2 Yönetmeni",
                Players = new[] {"1. Oyuncu", "2. Oyuncu", "3. Oyuncu"},
                ImageUrl = "2.jpg"
            },
            new()
            {
                Id = 3,
                Title = "Film 3",
                Description = "Film 3 Açıklama",
                Director = "Film 3 Yönetmeni",
                Players = new[] {"1. Oyuncu", "2. Oyuncu", "3. Oyuncu"},
                ImageUrl = "3.jpg"
            },
        };
        
        
            return View(movies);
        }

       
    }
}