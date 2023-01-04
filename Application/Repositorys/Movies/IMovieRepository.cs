using Domain.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositorys.Movies
{
    public interface IMovieRepository
    {
        public Task<bool> CreateMovie(Movie movie);
        public Task<bool> UpdateMovie(Movie movie);
        public Task<Movie> GetMovie(int movieId);
    }
}
