using Domain.Movies;
using Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Rooms
{
    public class CinemaRoom
    {
        public MoviePlayer MoviePlayer { get; }
        public Chat Chat { get; }

        public List<User> Guests { get; set; }
        public User Admin { get; set; }
        

    }
}
