using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
using MovieApp.Web.Entities;
using MovieApp.Web.Models;

namespace MovieApp.Web.ViewComponents
{
    public class GenresViewComponent:ViewComponent
    {
        private readonly MovieDbContext _context;

        public GenresViewComponent(MovieDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedGenre = RouteData.Values["id"];
            List<Genre> genres = _context.Genres.ToList();
            return View(genres);
        }
    }
}