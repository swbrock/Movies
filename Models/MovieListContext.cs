using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class MovieListContext : DbContext
    {
        public MovieListContext(DbContextOptions<MovieListContext> options) : base(options)
        {
            //Leave blank
        }

        //creates the table responses into the database
        public DbSet<MovieLists> Responses { get; set; }
        //We need to seed these three movies into the database
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieLists>().HasData(
                new MovieLists
                {
                    MovieId = 1,
                    Category = "Drama",
                    Title = "A Walk to Remember",
                    Year = 2002,
                    Director = "Adam Shankman",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = "Get ready to cry"
                },
                new MovieLists
                {
                    MovieId = 2,
                    Category = "Action",
                    Title = "Spiderman: No Way Home",
                    Year = 2021,
                    Director = "Jon Watts",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new MovieLists
                {
                    MovieId = 3,
                    Category = "Action",
                    Title = "Tenet",
                    Year = 2020,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "Your mind might break"
                }
            );
        }
    }
}