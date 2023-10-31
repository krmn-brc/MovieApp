using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;

namespace MovieApp.Web.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        Movie movie =  new()
            {
                Id = 1,
                Title = "Film ",
                Description = "Film  Açıklama",
                Director = "Film  Yönetmeni",
                Players = new[] {"1. Oyuncu", "2. Oyuncu", "3. Oyuncu"},
                ImageUrl = "2.jpg"
            };
          
        return View(movie);
    }

    [HttpGet("[action]")]
    public IActionResult About()
    {
        string ab = "About page welcome!".ToUpper();
        return View();
    }
}
