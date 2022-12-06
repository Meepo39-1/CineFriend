using Application.Repositorys.Movies;
using Application.Repositorys.Rooms;
using Application.Repositorys.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public class CinemaRoomFacade
    {
        private ICinemaRoomRepository _cinemaRoomRepo;
        private IChatRepository _chatRoomRepo;
        private IUserRepository _adminRepo;
        private IMovieLibraryRepository _movieLibraryRepo;
        private IMoviePlayerRepository _moviePlayerRepo;
        private IFriendListRepository _friendListRepo
        
        public CinemaRoomFacade(ICinemaRoomRepository cinemaRoomRepo,IChatRepository chatRoomRepo,
            IMoviePlayerRepository moviePlayerRepo, IMovieLibraryRepository _movieLibraryRepo,
            IUserRepository adminRepo, IFriendListRepository friendListRepo)
        {
            _cinemaRoomRepo = cinemaRoomRepo;
            _adminRepo = adminRepo;
            _chatRoomRepo = chatRoomRepo;
            _movieLibraryRepo = _movieLibraryRepo;
            _friendListRepo = friendListRepo;

        }

        public void PlayMovie(string adminId, string movieName)
        {   
            //Getting dedpendencies
            string cinemaRoomId = _cinemaRoomRepo.GetCinemaRoomId();
            var movieLibrary = _movieLibraryRepo.GetMovieLibrary(cinemaRoomID);
            var moviePlayer = _moviePlayerRepo.GetMoviePlayer(cinemaRoomId);
            var chatRoom = _chatRoomRepo.GetChat(cinemaRoomId);



            //querying movie data from adminLibrary
            var movieData = movieLibrary.GetMovieData();
         
            //sending movie data to the controller who will send it to the frontend to render it
            moviePlayer.Upload(movieData);
            
            //announcing the users that the movie has started playinh
            chatRoom.Write(movieName + " has started playing...");
                       
        }
        public void InviteFriend(string adminId, string FriendName)
        {
            string friendListId = _adminRepo.GetFriendList(admingId).Id;
            var friend = _friendListRepo.GetFriend(friendListId, FriendName);
            _cinemaRoomRepo.Invite(friend.Id);

        }

    }
}
