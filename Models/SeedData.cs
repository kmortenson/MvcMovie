using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-1-1"),
                        Genre = "History",
                        Rating = "NR",
                        Price = 14.99M,
                        Imagepath = "~/img/17Miracles.jpg"
                    },

                    new Movie
                    {
                        Title = "Ephraim's Rescue",
                        ReleaseDate = DateTime.Parse("2013-1-1"),
                        Genre = "Adventure",
                        Rating = "NR",
                        Price = 14.99M,
                        Imagepath = "~/img/EphrainsRescue.jpg"
                    },

                    new Movie
                    {
                        Title = "Ultimate Questions",
                        ReleaseDate = DateTime.Parse("2014-1-1"),
                        Genre = "Documentary",
                        Rating = "NR",
                        Price = 19.99M,
                        Imagepath = "~/img/Ultimate_Questions.jpg"
                    },

                    new Movie
                    {
                        Title = "The Book of Mormon and the New World DNA",
                        ReleaseDate = DateTime.Parse("2008-9-30"),
                        Genre = "Documentary",
                        Rating = "NR",
                        Price = 12.99M,
                        Imagepath = "~/img/Bk_Mormon_New_World_DNA.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}