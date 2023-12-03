using System.ComponentModel.DataAnnotations;

namespace CinemaApplicationAspNetCoreMVC.Models;

public class Producer
{
    [Key] public int Id { get; private set; }
    public string ProfilePictureUrl { get; private set; }
    public string FullName { get; private set; }
    public string Bio { get; private set; }
}