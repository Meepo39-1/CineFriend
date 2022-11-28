using Application.Repositorys.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.Querys.LoginUser
{
    internal class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, string>
    {
        IUserRepository _userRepository;
        public Task<string> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var user = _userRepository.GetUser(int.Parse(request.userInfo.Name));

            return Task.FromResult(request.userInfo.Name);
        }
    }
}
