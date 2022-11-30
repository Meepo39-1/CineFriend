using Domain.Movies;
using Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Users.Commands.UpdateUser
{
    public class UserDTO
    {
        public MovieLibrary movies;
        public string ID { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }
        public MovieLibrary Movies { get; }

        public FriendList Friends { get; }
    }
}
