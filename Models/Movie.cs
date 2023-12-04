using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaApplicationAspNetCoreMVC.Models;

public class Movie
{
    [Key] public int Id { get; private set; }

    public string Name { get; private set; }
    public string Description { get; private set; }
    public double Price { get; private set; }
    public string ImageUrl { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }
    public MovieCategory Category { get; private set; }

    public IList<Actor_Movie> ActorMovies { get; private set; }

    public int CinemaId { get; private set; }
    [ForeignKey("CinemaId")] public Cinema Cinema { get; private set; }

    public int ProducerId { get; private set; }
    [ForeignKey("ProducerId")] public Producer Producer { get; private set; }

    public Movie(int id, string name, string description, double price, string imageUrl, DateTime startDate,
        DateTime endDate, MovieCategory category, int cinemaId,
        int producerId)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
        ImageUrl = imageUrl;
        StartDate = startDate;
        EndDate = endDate;
        Category = category;
        CinemaId = cinemaId;
        ProducerId = producerId;
    }
}