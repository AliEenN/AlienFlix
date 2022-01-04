using AlienFlix.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlienFlix.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Relationship Between Movie And Genre
            builder.Entity<Genre>()
                .HasMany(e => e.Movies)
                .WithMany(e => e.Genres)
                .UsingEntity<GenreMovie>(
                    e => e
                    .HasOne(e => e.Movie)
                    .WithMany(e => e.GenresMovies)
                    .HasForeignKey(e => e.MovieId),
                    e => e
                    .HasOne(e => e.Genre)
                    .WithMany(e => e.GenresMovies)
                    .HasForeignKey(e => e.GenreId),
                    e =>
                    {
                        e.HasKey(e => new { e.GenreId, e.MovieId });
                    }
                );
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<GenreMovie> GenresMovies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
