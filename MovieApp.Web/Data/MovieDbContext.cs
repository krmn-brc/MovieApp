using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieApp.Web.Entities;

namespace MovieApp.Web.Data
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options):base(options)
        {
            
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Director> Directors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>()
            .HasData(MovieRepository.Movies);

            modelBuilder.Entity<Genre>()
            .HasData(GenreRepository.Genres);

            modelBuilder.Entity<Director>()
            .HasData(DirectorRepository.Directors);
        }
    }
}