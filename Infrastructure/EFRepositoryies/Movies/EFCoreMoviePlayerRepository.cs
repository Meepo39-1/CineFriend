using Application.Repositorys.Movies;
using Domain.Movies;
using Domain.Rooms;
using Infrastructure.EntityFrameworkDatabase.Models.Movies;
using Infrastructure.EntityFrameworkDataBase.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EFRepositoryies.Movies
{
    public class EFCoreMoviePlayerRepository : IMoviePlayerRepository
    {
        private ApplicationDbContext _dbContext;
        
        public EFCoreMoviePlayerRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<int> CreateMoviePlayer(CinemaRoom cinemaRoom)
        {
            var newMoviePlayerRecord = new MoviePlayerType();
            newMoviePlayerRecord.Language = cinemaRoom.MoviePlayer.Language;
            newMoviePlayerRecord.CinemaRoomTypeId = cinemaRoom.Id;

            _dbContext.Add(newMoviePlayerRecord);
            _dbContext.SaveChanges();



            return Task.FromResult(newMoviePlayerRecord.Id);
        }

        public Task<bool> DeleteMoviePlayer(int cinemaRoomId)
        {
            throw new NotImplementedException();
        }

        public Task<MoviePlayer> GetMoviePlayer(int cinemaRoomId)
        {
            var moviePlayerRecord = _dbContext.MoviePlayers.First(m => m.CinemaRoomId == cinemaRoomId);

            var moviePlayerDomain = new MoviePlayer();

            moviePlayerDomain.Language = moviePlayerRecord.Language;

            return Task.FromResult(moviePlayerDomain);

        }
    }
}
