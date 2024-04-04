using Movies.Client.Models;

namespace Movies.Client.APIServices
{
    public interface IMovieAPIService
    {
        Task<IEnumerable<Movie>> GetMovies();

        Task<Movie> GetMovieById(int id);

        Task<Movie> CreateMovie(Movie movie);

        Task<Movie> UpdateMovie(Movie movie);

        Task<Movie> DeleteMovie(int id);

    }
}
