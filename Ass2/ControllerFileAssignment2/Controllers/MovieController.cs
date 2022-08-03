using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Api2AssignmentLibrary.models;
using Api2AssignmentLibrary.repository;

namespace ControllerFileAssignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieRepo MovieRepository;

        public MovieController()
        {
            MovieRepository = new MovieRepo();
        }

        [HttpPost , Route("AddMovie")]

        public IActionResult AddMovie(Movie movie)
        {
            MovieRepository.AddMovie(movie);
            return StatusCode(200, movie);
        }

        [HttpGet, Route("GetMovies")]
        public IActionResult GetMovies()
        {
            List<Movie> movies = MovieRepository.GetMovies();
            return StatusCode(200, movies);
        }

        [HttpGet, Route("GetMovieByName/{Name}")]
        public IActionResult GetMovieByName(string Name)
        {
            return StatusCode(200, MovieRepository.GetMovieByName(Name));
        }
        [HttpGet, Route("GetMovieByActor/{Actor}")]
        public IActionResult GetMovieByActor(string Actor)
        {
            return StatusCode(200, MovieRepository.GetMovieByActor(Actor));

        }

        [HttpGet, Route("GetMovieByReleaseYear/{Year}")]

        public IActionResult GetMovieByReleaseYear(int Year)
        {
            return StatusCode(200, MovieRepository.GetMovieByReleaseYear(Year));
        }

        [HttpGet, Route("GetMovieByDirector/{Director}")]
        public IActionResult GetMovieByDirector(string Director)
        {
            return StatusCode(200, MovieRepository.GetMovieByDirector(Director));
        }


    }
}
