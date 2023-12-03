using CinemaApplicationAspNetCoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaApplicationAspNetCoreMVC.Data;

public class CinemaDbContext : DbContext
{
    public CinemaDbContext(DbContextOptions<CinemaDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor_Movie>().HasKey(am => new
        {
            am.ActorId,
            am.MovieId
        });
        modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.ActorMovies)
            .HasForeignKey(m => m.MovieId);
        modelBuilder.Entity<Actor_Movie>().HasOne(a => a.Actor).WithMany(am => am.ActorMovies)
            .HasForeignKey(a => a.ActorId);
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Actor> Actors { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Producer> Producers { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Actor_Movie> ActorMovies { get; set; }
}