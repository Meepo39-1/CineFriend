using Application.Repositorys.Movies;
using Domain.Movies;
using Infrastructure.EntityFrameworkDataBase.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EFRepositoryies.Movies
{
    public class EFCoreMovieRepository : IMovieRepository
    {
        private ApplicationDbContext _dbContext;

        public EFCoreMovieRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<bool> CreateMovie(Movie movie)
        {
            var newMovie = movie;
            _dbContext.Movies.Add(newMovie);
            _dbContext.SaveChanges();
            return Task.FromResult(true);
        }

        public Task<Movie> GetMovie(int movieId)
        {
            var movie = _dbContext.Movies.First(m => m.Id == movieId);
            return Task.FromResult(movie);
        }

        public Task<bool> UpateMovie(Movie movie)
        {
            _dbContext.Movies.Update(movie);
            return Task.FromResult(true);
        }
    }
}
