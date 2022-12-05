using Application.Repositorys.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Users.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, string>
    {
        IUserRepository _userRepository;
        UserDTO _userInfo;
        
        public UpdateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<string> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {   
            List<string> changes = new List<string>();
            _userInfo = request.userInfo;

            foreach(var field in _userInfo.GetType().GetFields())
            {
                changes.Add(field.Name);
            }
            try
            {
                _userRepository.UpdateUser(_userInfo.Id);
                return Task.FromResult("User updated");
            }
            catch(Exception e)
            {
                return Task.FromResult($"User not updated because of error {e.Message}");
            }
            
        }
    }
}
