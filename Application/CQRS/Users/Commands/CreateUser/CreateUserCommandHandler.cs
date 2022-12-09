using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Users;
using Domain.Rooms;
using Application.Repositorys.Users;
using Application.Repositorys.Rooms;

namespace Application.CQRS.Users.Commands.CreateUser
{

    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, string>
    {
        private readonly IUserRepository _userRepository;
        private readonly ICinemaRoomRepository _roomRepository;
  

        public CreateUserCommandHandler(IUserRepository userRepository, ICinemaRoomRepository roomRepository)
        {
            _userRepository = userRepository;
            _roomRepository = roomRepository;
        }

        public Task<string> Handle(CreateUserCommand command, CancellationToken cancellationToken)
        {   
            UserDTO userInfo = command.userInfo;
            //  Admin(string id, string name, string password, MovieLibrary movies, FriendList friends) : base(id, name, password, movies, friends)

            var newUser = new User(userInfo.ID, userInfo.Name, userInfo.Password, userInfo.Movies, userInfo.Friends);
            _userRepository.CreateUser(newUser);
            var cinemaRoom = new CinemaRoom();
            cinemaRoom.Admin = newUser;
            _roomRepository.CreateCinemaRoom(cinemaRoom);

            return Task.FromResult(userInfo.Name);
        }
    }
}
