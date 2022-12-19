using Domain.Movies;
using Domain.Rooms;
using Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositorys.Movies
{
    public interface IMovieLibraryRepository
    {
        public Task<int> CreateMovieLibrary(User user);

        public Task<bool> DeleteMovieLibrary(int userId);
        public Task<MovieLibrary> GetMovieLibrary(int userId);
    }
}
