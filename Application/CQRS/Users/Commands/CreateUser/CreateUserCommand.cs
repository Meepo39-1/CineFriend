using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Users.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<string>
    {
        public UserDTO userInfo;

        

    }
}
