using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Web.Entities;

namespace MovieApp.Web.Data
{
    public class GenreRepository
    {
        private static readonly List<Genre> genres = null;

        static GenreRepository()
        {
             genres = new()
            {
                new(){ Id = 1, Name = "Romantik"},
                new(){Id = 2, Name = "Komedi"},
                new(){Id = 3, Name = "Macera"},
                new(){Id = 4, Name = "Savaş"},
                new(){Id = 5, Name = "Animasyon"}
            };
        }

        public static List<Genre> Genres => genres;

        public static void Add(Genre genre) => genres.Add(genre);

        public static Genre GetByIdGenre(int id) 
        => genres.FirstOrDefault(x => x.Id == id);
    }
}