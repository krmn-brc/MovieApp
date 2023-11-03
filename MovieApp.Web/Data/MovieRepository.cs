using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Web.Models;

namespace MovieApp.Web.Data
{
    public class MovieRepository
    {
        private static readonly List<Movie> movies = null;
        static MovieRepository()
        {
            movies = new()
            {
                new()
                {
                    Id = 1,
                    GenreId = 4,
                    Title = "Jiu Jitsu",
                    Description = "Every six years, an ancient order of jiu-jitsu fighters joins forces to battle a vicious race of alien invaders. But when a celebrated war hero goes down in defeat, the fate of the planet and mankind hangs in the balance.",
                    Director = "Dimitri Logothetis",
                    Players = new[] {"Nicolas Cage", "Alain Moussi"},
                    ImageUrl = "jiujitsu.jpg"
                },
                new()
                {
                    Id = 2,
                    GenreId = 2,
                    Title = "Fatman",
                    Description = "A rowdy, unorthodox Santa Claus is fighting to save his declining business. Meanwhile, Billy, a neglected and precocious 12 year old, hires a hit man to kill Santa after receiving a lump of coal in his stocking.",
                    Director = "Eshom Nelms",
                    Players = new[] {"Mel Gibson", "Walton Goggins", "Marianne Jean-Baptiste"},
                    ImageUrl = "fatman.jpg"
                },
                new()
                {
                    Id = 3,
                    GenreId = 4,
                    Title = "The Dalton Gang",
                    Description = "When their brother is killed by an outlaw, three Dalton brothers join their sheriff's dept. When they're cheated by the law, they turn to crime. Trying to outdo Jesse James, they try to rob two banks at once in 1892. Things get ugly.",
                    Director = "Christopher Forbes",
                    Players = new[] {"William Adams", "Jezibell Anat", "Gunner Bridger"},
                    ImageUrl = "tdaltong.jpg"
                },
                new()
                {
                    Id = 4,
                    GenreId = 4,
                    Title = "Tenet",
                    Description = "Armed with only one word, Tenet, and fighting for the survival of the entire world, a Protagonist journeys through a twilight world of international espionage on a mission that will unfold in something beyond real time.",
                    Director = "Christopher Nolan",
                    Players = new[] {"Juhan Ulfsak", "Jefferson Hall", "Ivo Uukkivi"},
                    ImageUrl = "tenet.jpg"
                },
                new()
                {
                    Id = 5,
                    GenreId = 3,
                    Title = "Film 5",
                    Description = "A group of high school students form a coven of witches.",
                    Director = "Zoe Lister-Jones",
                    Players = new[] {"Cailee Spaeny", "Zoey Luna", "Gideon Adlon"},
                    ImageUrl = "tcraft.jpg"
                },
                new()
                {
                    Id = 6,
                    GenreId = 3,
                    Title = "Hard Kill",
                    Description = "The work of billionaire tech CEO Donovan Chalmers (Willis) is so valuable that he hires mercenaries to protect it, and a terrorist group kidnaps his daughter just to get it.",
                    Director = "Matt Eskandari",
                    Players = new[] {"Jesse Metcalfe", "Bruce Willis", "Lala Kent"},
                    ImageUrl = "hardkill.jpeg"
                },
            };
            
        }

        public static List<Movie> Movies => movies;

        public static void Add(Movie movie) 
        { 
            movie.Id = movies.Count() +1;
            movies.Add(movie);
        }

        public static Movie GetById(int id) 
        => movies.FirstOrDefault(x => x.Id == id);

        public static void Update(Movie movie)
        {
            var m = GetById(movie.Id);
            m.Title = string.IsNullOrEmpty(movie.Title) ? m.Title : movie.Title;
            m.Director = string.IsNullOrEmpty(movie.Director) ? m.Director : movie.Director;
            m.ImageUrl = string.IsNullOrEmpty(movie.ImageUrl) ? m.ImageUrl : movie.ImageUrl;
            m.Description = string.IsNullOrEmpty(movie.Description) ? m.Description : movie.Description;
            m.GenreId = movie.GenreId < 1 ? m.GenreId : movie.GenreId;
        }

        public static void Delete(int id)
        {
            var m = GetById(id);
            movies.Remove(m);
        }

    }
}