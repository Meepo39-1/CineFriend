using Application.Repositorys.Movies;
using Domain.Movies;
using Domain.Users;
using Infrastructure.EntityFrameworkDatabase.Models.Movies;
using Infrastructure.EntityFrameworkDataBase.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EFRepositoryies.Movies
{
    public class EFCoreMovieLibraryRepository : IMovieLibraryRepository
    {
        private ApplicationDbContext _dbContext;

        public EFCoreMovieLibraryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<int> CreateMovieLibrary(User user)
        {
            var newMovieLibRecord = new MovieLibraryType();
            newMovieLibRecord.UserTypeId = user.Id;

            _dbContext.Add(newMovieLibRecord);
            _dbContext.SaveChanges();

            return Task.FromResult(newMovieLibRecord.Id);

        }

        public Task<bool> DeleteMovieLibrary(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<MovieLibrary> GetMovieLibrary(int userId)
        {
            var movieLibRecord = _dbContext.MovieLibraries.First(m => m.UserId == userId);

            var domainMovieLib = new MovieLibrary();
            var movieList = new List<Movie>();

            foreach (var movie in movieLibRecord.Movies)
            {
                var domainMovie = new Movie();
                domainMovie.Name = movie.Name;
                domainMovie.Id = movie.Id;
                domainMovie.Rating = movie.Rating;
                domainMovie.Genre = movie.Genre;
                movieList.Add(domainMovie);

            }
            domainMovieLib.Movies = movieList;

            return Task.FromResult(domainMovieLib);
           
        }
    }
}