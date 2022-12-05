using Application.Interfaces;
using Domain.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositorys.Rooms
{
    public interface ICinemaRoomRepository : ISocializer, IHost
    {
        void CreateCinemaRoom(CinemaRoom cinemaRoomData);
        

        void UpdateCinemaRoom(CinemaRoom cinemaRoomData);

        void DeleteCinemaRoom(CinemaRoom cinemaRoomData);

        void DeleteCinemaRoom(string adminID);
        void RemoveCinemaRoom(CinemaRoom cinemaRoomData);

        CinemaRoom GetCinemaRoom(string adminID);

        Chat GetRoomChat(string cinemaRoomID);

        void Invite(string link, List<Domain.Users.User> users);

    }
}
