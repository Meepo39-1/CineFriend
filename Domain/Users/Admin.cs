using Domain.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users
{
    internal class Admin : User
    {


        public Admin(string id = "NULL", string name = "NULL", string password = "NULL", MovieLibrary movies = null, FriendList friends = null) : base(id, name, password, movies, friends)
        {

        }
        public override void AddFriend(string friendName)
        {
            throw new NotImplementedException();
        }

        public override void AddFriend(int friendId)
        {
            throw new NotImplementedException();
        }

        public override object Clone()
        {
            
            return new Admin(this.ID,this.Name, this.Password, this.Movies, this.Friends);
        }

        public override void RemoveFriend(string friendName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveFriend(int friendId)
        {
            throw new NotImplementedException();
        }

        public override void WatchMovie(int movieId)
        {
            throw new NotImplementedException();
        }

        public override void WatchMovie(string movieName)
        {
            throw new NotImplementedException();
        }

        public override void WriteMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}
