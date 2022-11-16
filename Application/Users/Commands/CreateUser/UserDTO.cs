using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Movies;
using Domain.Users;

namespace Application.Users.Commands.CreateUser
{
    public class UserDTO
    {
        public MovieLibrary movies;
        public int ID { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }
        public MovieLibrary Movies { get; }

        public FriendList Friends { get; }
    }
}
