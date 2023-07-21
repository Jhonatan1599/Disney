// Ignore Spelling: App

using System.Text.Json;
using DisneyAPI.DbContexts;
using DisneyAPI.Domain.Entities;

namespace DisneyAPI.Domain
{
    public class AppDbContextSeed
    {
        public static async Task SeedAsync(ApplicationDbContext context)
        {
            if (!context.Character!.Any())
            {
                var charactersData = File.ReadAllText("../DisneyAPI/Domain/SeedData/Characters.json");
                var characters = JsonSerializer.Deserialize<List<Character>>(charactersData);
                context.Character!.AddRange(characters!);
            }
            if (!context.Genre!.Any())
            {
                var genresData = File.ReadAllText("../DisneyAPI/Domain/SeedData/Genres.json");
                var genres = JsonSerializer.Deserialize<List<Genre>>(genresData);
                context.Genre!.AddRange(genres!);
            }
            if (!context.MoviesOrSerie!.Any())
            {
                var moviesData = File.ReadAllText("../DisneyAPI/Domain/SeedData/MoviesOrSeries.json");
                var movies = JsonSerializer.Deserialize<List<MovieOrSerie>>(moviesData);
                context.MoviesOrSerie!.AddRange(movies!);
            }

            

            if (context.ChangeTracker.HasChanges()) await context.SaveChangesAsync();
        }
    }
}
