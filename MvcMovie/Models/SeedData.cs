using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

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
                    Title = "Hit3",
                    ReleaseDate = DateTime.Parse("2025-04-15"),
                    Genre = "Action",
                    Rating = "8.5",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Devara Part1",
                    ReleaseDate = DateTime.Parse("2024-10-14"),
                    Genre = "Action",
                    Rating = "9",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ironman",
                    ReleaseDate = DateTime.Parse("2008-12-22"),
                    Genre = "Action/Sci-fi",
                    Rating = "8.5",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Salar",
                    ReleaseDate = DateTime.Parse("2023-12-10"),
                    Genre = "Action",
                    Rating = "9.5",
                    Price = 8.99M
                }
            );
            context.SaveChanges();
        }
    }
}