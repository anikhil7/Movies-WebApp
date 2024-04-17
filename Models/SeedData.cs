using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication_L2V2.Data;
using System.Linq;

namespace WebApplication_L2V2.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebApplication_L2V2Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WebApplication_L2V2Context>>()))
            {
                // Look for any movies.
                if (context.Movies.Any())
                {
                    return;   // DB has been seeded
                }
                context.Movies.AddRange(
                    new Movies
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Rating = "R",
                        Price = 7.99M
                    },
                    new Movies
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Rating = "R",
                        Price = 8.99M
                    },
                    new Movies
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Rating = "R",
                        Price = 9.99M
                    },
                    new Movies
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Rating = "R",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
