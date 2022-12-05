using Application.Interfaces;
using Domain.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositorys.Movies
{
    public class CachedMovieLibrary : IMovieLibraryRepository
    {
        private readonly IMovieLibraryRepository _movieLibraryRepository;
        private readonly string _libraryId;
        private List<Movie> _cachedMovieList;
      
        public CachedMovieLibrary(IMovieLibraryRepository movieLibraryRepository,string libraryId)
        {
            _movieLibraryRepository = movieLibraryRepository;
            _libraryId = libraryId;
        }

        public void CreateMovieLibrary(MovieLibrary library)
        {
            _movieLibraryRepository.CreateMovieLibrary(library);
        }

        public List<Movie> GetAllMovies(string movieLibraryId)
        {   
            if (_cachedMovieList == null)
            {
                _cachedMovieList = _movieLibraryRepository.GetAllMovies(movieLibraryId);
            }
            return _cachedMovieList;
        }

        public List<Movie> GetMovie(string movieName)
        {
            return _cachedMovieList.FindAll(m => m.Name == movieName);
           
           
            var movies = _movieLibraryRepository.GetMovie(_libraryId, movieName);
            _cachedMovieList.AddRange(movies);
            return movies;


            
        }

        public List<Movie> GetMovie(string libraryId, string movieName)
        {
            throw new NotImplementedException();
        }

        public MovieLibrary GetMovieLibrary(string id)
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
           
            isPlaying = false;
           
        }

        public void Play()
        {
            
            isPlaying = true;
            
        }

        public void RemoveMovieLibrary(string id)
        {
            throw new NotImplementedException();
        }

        public void UploadMovie(Movie movie)
        {
            if (_movieList == null)
            {
                _movieLibraryRepository.GetAllMovies();
            }
            
        }
        
    }
}
