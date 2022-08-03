using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api2AssignmentLibrary.models;
namespace Api2AssignmentLibrary.repository
{
    public class MovieRepo : IMovieRepo
    {
        static List<Movie> movies = new List<Movie>();

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public List<Movie> GetMovies()
        {
            return movies;
        }

        public Movie GetMovieByName(string Name)
        {
            foreach (Movie movie in movies)
            {
                if(movie.MovieName == Name)
                    return movie;
            }
            return null;
        }

        public List<Movie> GetMovieByActor(string Actor)
        {
            List<Movie> temp = new List<Movie>();
            foreach(Movie movie in movies)
            {
                if(movie.Actor == Actor)
                {
                    temp.Add(movie);
                }
            }
            return temp;
        }

        public List<Movie> GetMovieByReleaseYear(int Year)
        {
            List<Movie> temp = new List<Movie>();
            foreach (var movie in movies)
            {
                if (movie.ReleaseDate.Year == Year)
                    temp.Add(movie);
            }
            return temp;
        }

        public List<Movie> GetMovieByDirector(string Director)
        {
            List<Movie> temp = new List<Movie>();
            foreach ( Movie movie in movies)
            {
                if (movie.Director == Director)
                    temp.Add(movie);
            }
            return temp;
        }
    }
}
