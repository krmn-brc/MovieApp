using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
using MovieApp.Web.Models;

namespace MovieApp.Web.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        HomePageViewModel viewModel = new()
        {
            PopularMovies = MovieRepository.Movies
        };
        return View(viewModel);
    }

  
    public IActionResult About()
    {
       
        return View();
    }
}
