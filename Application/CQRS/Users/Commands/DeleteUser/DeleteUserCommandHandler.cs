using Application.Repositorys.Rooms;
using Application.Repositorys.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Users.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand,string>
    {
        private readonly IUserRepository _userRepository;
        private readonly ICinemaRoomRepository _roomRepository;

        public DeleteUserCommandHandler(IUserRepository userRepository, ICinemaRoomRepository roomRepository)
        {
            _userRepository = userRepository;
            _roomRepository = roomRepository;
        }


        public Task<string> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {   //how to make sure this value doesn't change?
            string userID = request.userDTO.ID;
            try
            {
                _roomRepository.DeleteCinemaRoom(userID);
            }
            catch (Exception e)
            {
                return Task.FromResult($"Couldn't delete CinemaRoom of admin with user id{userID}");
            }
            try
            {
                _userRepository.DeleteUser(userID);
                return Task.FromResult($"User with id {userID} deleted");
            }
            catch(Exception e)
            {
                return Task.FromResult($"Deleting user with ud {userID} failed, because of error {e.Message}");
            }
          
        }
    }
}
