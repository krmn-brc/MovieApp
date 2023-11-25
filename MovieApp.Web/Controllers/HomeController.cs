using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
using MovieApp.Web.Models;

namespace MovieApp.Web.Controllers;

public class HomeController : Controller
{
    private readonly MovieDbContext _context;

    public HomeController(MovieDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        HomePageViewModel viewModel = new()
        {
            PopularMovies = _context.Movies.ToList()
        };
        return View(viewModel);
    }

  
    public IActionResult About()
    {
       
        return View();
    }
}
