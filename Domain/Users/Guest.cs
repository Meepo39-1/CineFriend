using Domain.Movies;
using Domain.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Domain.Users
{
    internal class Guest : User
    {
       
       // List<CinemaRoom> CinemaRooms { get; }
        /* string ID { get; set; }
         string Name { get; set; }

         string Password { get; set; }
         MovieLibrary movies { get; }

         FriendList friends { get; }
        */

        Guest(string id, string name, string password, MovieLibrary movies, FriendList friends) : base(id, name, password, movies, friends)
        {
            

        }

        public Guest()
        {
        }

        public override object Clone()
        {
            return new Guest(ID,Name,Password,Movies,Friends);
        }

        public override void WatchMovie(int movieId)
        {
            throw new NotImplementedException();
        }

        public override void WatchMovie(string movieName)
        {
            throw new NotImplementedException();
        }

        public override void AddFriend(string friendName)
        {
            throw new NotImplementedException();
        }

        public override void AddFriend(int friendId)
        {
            throw new NotImplementedException();
        }



        public override void RemoveFriend(string friendId)
        {
            bool found = false;
            foreach(User user in Friends)
            {
                if(user.ID.Equals(friendId))
                {
                    Friends.RemoveFriend(user);
                    found = true;
                    
                }
            }
            if (!found)
            {
                throw new KeyNotFoundException();
            }
           
         
        }

        public override void WriteMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}
