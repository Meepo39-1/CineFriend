using Application.Interfaces;
using Application.Repositorys;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Users;

namespace Application.Users.Commands.CreateUser
{
    
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUserRepository _userRepository;

        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<int> Handle(CreateUserCommand command, CancellationToken cancellationToken)
        {   
            UserDTO userInfo = command.userInfo;
            //  Admin(string id, string name, string password, MovieLibrary movies, FriendList friends) : base(id, name, password, movies, friends)

            Admin userAdminVersion = new Admin(userInfo.ID, userInfo.Name, userInfo.Password, userInfo.Movies, userInfo.Friends);
            Guest userGuestVersion = new Guest(userInfo.ID, userInfo.Name, userInfo.Password, userInfo.Movies, userInfo.Friends);
            _userRepository.CreateUser(userAdminVersion, userGuestVersion);

            return Task.FromResult(userInfo.ID);
        }
    }
}
