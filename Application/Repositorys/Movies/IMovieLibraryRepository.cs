using Domain.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositorys.Movies
{
    public interface IMovieLibraryRepository
    {
        public void CreateMovieLibrary(MovieLibrary library);
        public void RemoveMovieLibrary(string id);
        public MovieLibrary GetMovieLibrary(string id);
        public List<Movie> GetMovie(string libraryId, string movieName);
        public List<Movie> GetAllMovies(string movieLibraryId);

    }
}
