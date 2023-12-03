using System.ComponentModel.DataAnnotations;

namespace CinemaApplicationAspNetCoreMVC.Models;

public class Actor
{
    [Key] public int Id { get; private set; }
    public string ProfilePictureUrl { get; private set; }
    public string FullName { get; private set; }
    public string Bio { get; private set; }
    public IList<Actor_Movie> ActorMovies { get; private set; }

    public Actor(int id, string profilePictureUrl, string fullName, string bio, IList<Actor_Movie> actorMovies)
    {
        Id = id;
        ProfilePictureUrl = profilePictureUrl;
        FullName = fullName;
        Bio = bio;
        ActorMovies = actorMovies;
    }
}