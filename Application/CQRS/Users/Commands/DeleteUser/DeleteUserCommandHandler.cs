using Application.Repositorys.Rooms;
using Application.Repositorys.Users;
using Domain.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Users.Commands.DeleteUser
{
      public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand,bool>
       {
           private readonly IUserRepository _userRepository;
           private User _user;


           public DeleteUserCommandHandler(IUserRepository userRepository)
           {
               _userRepository = userRepository;

            
           }


           public Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
            {
                //_userInfo.Id = request.userDTO.Id;

                _userRepository.DeleteUser(request.userDTO.Id);



                return Task.FromResult(true);   

           }
       }
}
