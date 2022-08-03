using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api2AssignmentLibrary.models;
namespace Api2AssignmentLibrary.repository
{
    public interface IMovieRepo
    {
        void AddMovie(Movie movie);

        List<Movie> GetMovies();

        Movie GetMovieByName(string Name);

        List<Movie> GetMovieByActor(string Actor);

        List<Movie> GetMovieByReleaseYear(int Year);

        List<Movie> GetMovieByDirector(string Director);
    }
}
