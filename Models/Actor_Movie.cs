namespace CinemaApplicationAspNetCoreMVC.Models;

public class Actor_Movie
{
    public int ActorId { get; private set; }
    public Actor Actor { get; private set; }
    public int MovieId { get; private set; }
    public Movie Movie { get; private set; }

    public Actor_Movie(int actorId, int movieId)
    {
        ActorId = actorId;
        MovieId = movieId;
    }
}