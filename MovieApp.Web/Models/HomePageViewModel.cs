using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Web.Entities;

namespace MovieApp.Web.Models
{
    public class HomePageViewModel
    {
        public List<Movie> PopularMovies { get; set; }
    }
}