using Domain.Movies;
using Domain.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositorys.Movies
{
    public interface IMoviePlayerRepository
    {
        public Task<int> CreateMoviePlayer(CinemaRoom cinemaRoom);
        public Task<bool> DeleteMoviePlayer(int cinemaRoomId);
        public Task<MoviePlayer> GetMoviePlayer(int cinemaRoomId);
    }  
}
