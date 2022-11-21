using Domain.Movies;
using Domain.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users
{
    public class Admin : User
    {


        public Admin(int id, string name, string password, MovieLibrary movies, FriendList friends) : base(id, name, password, movies, friends)
        {
            //
        }
        public override User Clone()
        {
            return new Admin(ID, Name, Password, Movies, Friends);
        }
        public Up
    }
}
