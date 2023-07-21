// Ignore Spelling: Serie

using DisneyAPI.Domain.Entities;
using DisneyAPI.IdentyEntities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DisneyAPI.DbContexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Character>? Character { get; set; }
        public DbSet<MovieOrSerie>? MoviesOrSerie { get; set; }
        public DbSet<Genre>? Genre { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MovieOrSerie>()
                .HasMany(m => m.Characters)
                .WithMany(c => c.MoviesOrSeries)
                .UsingEntity(j => j.ToTable("MovieOrSerieCharacter"))
                .Property(e => e.CreationDate)
                .HasColumnType("timestamp without time zone");

            // Configure seed data
            //var animationGenreId = Guid.NewGuid();
            //var fantasyGenreId = Guid.NewGuid();
            //var familyGenreId = Guid.NewGuid();
            //var holidayGenreId = Guid.NewGuid();


            //modelBuilder.Entity<Genre>().HasData(
            //    new Genre { Id = animationGenreId, Name = "Animation" },
            //    new Genre { Id = fantasyGenreId, Name = "Fantasy" },
            //    new Genre { Id = familyGenreId, Name = "Family" },
            //    new Genre { Id = holidayGenreId, Name = "Holiday" }
            //);

            //modelBuilder.Entity<Character>().HasData(
            //    new Character { Id = Guid.NewGuid(), Name = "Mickey Mouse", Age = 92, Weight = 23.5f, Story = "Mickey Mouse is the iconic and beloved character in Disney's cartoons.", ImageUrl = "https://disney-api.app.csharpjourney.com/minnie.png" },
            //    new Character { Id = Guid.NewGuid(), Name = "Minnie Mouse", Age = 92, Weight = 21.4f, Story = "Minnie Mouse is Mickey Mouse's girlfriend and one of Disney's iconic characters.", ImageUrl = "https://disney-api.app.csharpjourney.com/mickey.png" }
       
            //);

            //modelBuilder.Entity<MovieOrSerie>().HasData(
            //    new MovieOrSerie { Id = Guid.NewGuid(), Title = "Steamboat Willie", CreationDate = new DateTime(1928, 11, 18), Rating = 8, ImageUrl = "https://disney-api.app.csharpjourney.com/Steamboat-Willie.jpg", GenreId = animationGenreId },
            //    new MovieOrSerie { Id = Guid.NewGuid(), Title = "Fantasia", CreationDate = new DateTime(1940, 11, 13), Rating = 7, ImageUrl = "https://disney-api.app.csharpjourney.com/fantasia.jpg", GenreId = fantasyGenreId },
            //    new MovieOrSerie { Id = Guid.NewGuid(), Title = "The Mickey Mouse Club", CreationDate = new DateTime(1955, 10, 3), Rating = 6, ImageUrl = "https://disney-api.app.csharpjourney.com/The-Mickey-Mouse-Club", GenreId = familyGenreId },
            //    new MovieOrSerie { Id = Guid.NewGuid(), Title = "Mickey's Once Upon a Christmas", CreationDate = new DateTime(1999, 11, 9), Rating = 7, ImageUrl = "https://disney-api.app.csharpjourney.com/Mickeys-Once-Upon-a-Christmas.jpg", GenreId = holidayGenreId }              
            //);
        }
    }
}
