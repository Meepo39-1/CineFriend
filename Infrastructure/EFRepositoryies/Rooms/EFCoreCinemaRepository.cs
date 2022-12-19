using Application.Repositorys.Rooms;
using Application.Repositorys.Users;
using Domain.Rooms;
using Infrastructure.EntityFrameworkDatabase.Models.Rooms;
using Infrastructure.EntityFrameworkDataBase.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EFRepositoryies.Rooms
{
    public class EFCoreCinemaRepository : ICinemaRoomRepository
    {
        private ApplicationDbContext _dbcontext;

        public EFCoreCinemaRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public Task<CinemaRoom> GetCinemaRoom(int CinemaId)
        {
            throw new NotImplementedException();
        }

        async Task<int> ICinemaRoomRepository.CreateCinemaRoom(CinemaRoom cinemaRoomData)
        {
            var cinemaRoomRecord = new CinemaRoomType();
            cinemaRoomRecord.UserTypeId = cinemaRoomData.Admin.Id;

            _dbcontext.Add(cinemaRoomRecord);
            _dbcontext.SaveChanges();

            return cinemaRoomRecord.Id;

        }

        Task<bool> ICinemaRoomRepository.DeleteCinemaRoom(CinemaRoom cinemaRoomData)
        {
            throw new NotImplementedException();
        }

        /*   Task<bool> ICinemaRoomRepository.DeleteCinemaRoom(string adminID)
           {
               throw new NotImplementedException();
           }

           Task<CinemaRoom> ICinemaRoomRepository.GetCinemaRoom(string adminID)
           {
               throw new NotImplementedException();
           }

           Task<Chat> ICinemaRoomRepository.GetRoomChat(string cinemaRoomID)
           {
               throw new NotImplementedException();
           }

           Task<int> ICinemaRoomRepository.UpdateCinemaRoom(CinemaRoom cinemaRoomData)
           {
               throw new NotImplementedException();
           }
        */
    }
}
