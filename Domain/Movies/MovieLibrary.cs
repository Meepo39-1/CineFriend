using Domain.Exceptions.InvalidParametersExceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Domain.Exceptions.NotFoundExceptions;

namespace Domain.Movies
{
    public class MovieLibrary : IEnumerable
    {
        List<Movie> _movies;

        public IEnumerator GetEnumerator()
        {
            return _movies.GetEnumerator();
        }

        public void AddMovie(Movie movie)
        {
            Debug.WriteLine("Adding Movie to Library");
            try
            {
                if (movie == null)
                {
                    throw new InvalidMovieException();
                }
                _movies.Add(movie);
            }
            catch (InvalidMovieException e)
            {
                Debug.WriteLine("Added invalid movie, throwing it to let client handle it");

                throw e;

            }

            
            
            _movies.Add((Movie)movie.Clone());
        }
        public Movie GetMovie(string name)
        {
            Debug.WriteLine("Searching for a movie");
            try
            {
                foreach (Movie movie in _movies)
                {
                    if (movie.Name.Equals(name))
                    {
                        return movie;
                    }
                }
                throw new MovieNotFoundException();
            }
            catch (MovieNotFoundException e) 
            {
                Debug.WriteLine("Movie not found, throwing exception to let client handle it");

                throw e;
            }
           
            

           
        }
    }
}
