using Application.Interfaces;
using Domain.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositorys.Rooms
{
    public interface ICinemaRoomRepository //: ISocializer, IHost
    {
        public Task<int> CreateCinemaRoom(CinemaRoom cinemaRoomData);


       // public Task<int> UpdateCinemaRoom(CinemaRoom cinemaRoomData);

        public Task<bool> DeleteCinemaRoom(CinemaRoom cinemaRoomData);

      //  public Task<bool> DeleteCinemaRoom(string adminID);
        // RemoveCinemaRoom(CinemaRoom cinemaRoomData);

        public Task<CinemaRoom> GetCinemaRoom(int CinemaId);

        //public Task<Chat> GetRoomChat(string cinemaRoomID);

        //void Invite(string link);

    }
}
