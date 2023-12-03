namespace CinemaApplicationAspNetCoreMVC.Models;

public class Actor_Movie
{
    public int ActorId { get; private set; }
    public Actor Actor { get; private set; }
    public int MovieId { get; private set; }
    public Movie Movie { get; private set; }

    public Actor_Movie(int actorId, Actor actor, int movieId, Movie movie)
    {
        ActorId = actorId;
        Actor = actor;
        MovieId = movieId;
        Movie = movie;
    }
}