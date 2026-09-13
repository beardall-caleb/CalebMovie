using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CalebMovie.Data;
using System;
using System.Linq;

namespace CalebMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new CalebMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<CalebMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return; // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Captain America: The First Avenger",
                    ReleaseDate = DateTime.Parse("2011-07-19"),
                    Genre = "Historical War",
                    Price = 14.00M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Captain America: The Winter Soldier",
                    ReleaseDate = DateTime.Parse("2014-04-04"),
                    Genre = "Spy War",
                    Price = 17.00M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Captain America: Civil War",
                    ReleaseDate = DateTime.Parse("2016-05-06"),
                    Genre = "Political War",
                    Price = 25.00M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Captain America: Brave New World",
                    ReleaseDate = DateTime.Parse("2025-02-14"),
                    Genre = "Political War",
                    Price = 18.00M,
                    Rating = "PG-13"
                }
            );
            context.SaveChanges();
        }
    }
}