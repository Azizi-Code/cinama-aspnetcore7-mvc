using System.ComponentModel.DataAnnotations;

namespace CinemaApplicationAspNetCoreMVC.Models;

public class Producer
{
    [Key] public int Id { get; private set; }
    public string ProfilePictureUrl { get; private set; }
    public string FullName { get; private set; }
    public string Bio { get; private set; }
    public IList<Movie> Movies { get; private set; }

    public Producer(int id, string profilePictureUrl, string fullName, string bio)
    {
        Id = id;
        ProfilePictureUrl = profilePictureUrl;
        FullName = fullName;
        Bio = bio;
    }
}