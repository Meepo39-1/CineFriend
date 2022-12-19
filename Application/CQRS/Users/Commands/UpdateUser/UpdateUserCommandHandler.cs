using Application.Repositorys;
using Application.Repositorys.Users;
using Domain.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Users.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, bool>
    {
        IUserRepository _userRepository;
     
        User _userInfo;
        
        public UpdateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _userInfo = new User();
        }

        public Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {



            _userInfo.Id = request.userInfo.Id;
            _userInfo.Name = request.userInfo.UserName;
            _userInfo.Password = request.userInfo.Password;


            try
            {
                _userRepository.UpdateUser(_userInfo);
                return Task.FromResult(true);
            }
            catch(Exception e)
            {
                return Task.FromResult(false);
            }
            
        }
    }
  
}
