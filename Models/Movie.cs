using System.ComponentModel.DataAnnotations;

namespace CinemaApplicationAspNetCoreMVC.Models;

public class Movie
{
    [Key] public int Id { get; private set; }

    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string ImageUrl { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public MovieCategory Category { get; set; }
    
}