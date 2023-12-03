using System.ComponentModel.DataAnnotations;

namespace CinemaApplicationAspNetCoreMVC.Models;

public class Cinema
{
    [Key] public int Id { get; private set; }
    public string Logo { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public IList<Movie> Movies { get; private set; }

    public Cinema(int id, string logo, string name, string description, IList<Movie> movies)
    {
        Id = id;
        Logo = logo;
        Name = name;
        Description = description;
        Movies = movies;
    }
}