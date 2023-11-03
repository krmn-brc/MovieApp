using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
using MovieApp.Web.Models;

namespace MovieApp.Web.ViewComponents
{
    public class GenresViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedGenre = RouteData.Values["id"];
            List<Genre> genres = GenreRepository.Genres;
            return View(genres);
        }
    }
}