using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;

namespace MovieApp.Web.ViewComponents
{
    public class GenresViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Genre> genres = new()
            {
                new(){Name = "Romantik"},
                new(){Name = "Komedi"},
                new(){Name = "Macera"},
                new(){Name = "Savaş"},
                new(){Name = "Animasyon"}
            };
            return View(genres);
        }
    }
}