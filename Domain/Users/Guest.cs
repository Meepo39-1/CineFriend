using Domain.Movies;
using Domain.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users
{
    internal class Guest : User
    {
       
        CinemaRoom CinemaRooms { get; }
        /* string ID { get; set; }
         string Name { get; set; }

         string Password { get; set; }
         MovieLibrary movies { get; }

         FriendList friends { get; }
        */

        Guest(string id, string name, string password, MovieLibrary movies, FriendList friends, CinemaRoom cinemaRooms = null) : base(id, name, password, movies, friends)
        {
            CinemaRooms = cinemaRooms;
        }

        public Guest()
        {
        }

        public override User Clone()
        {
            return new Guest();
        }
    }
}
