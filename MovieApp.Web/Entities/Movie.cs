using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public int? GenreId { get; set; }
        public int DirectorId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string?  ImageUrl { get; set; }
    }
}