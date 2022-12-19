using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Movies;
using Domain.Users;

namespace Application.CQRS.Users.Commands.CreateUser
{
    public class UserDTO
    {
        public string Name { get; set; }

        public string Password { get; set; }

    }
}
