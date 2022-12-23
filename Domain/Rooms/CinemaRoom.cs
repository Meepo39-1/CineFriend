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
        public int Id { get; set; }
        public string name { get; set; }
        public MoviePlayer MoviePlayer { get; set; }
        public Chat Chat { get; set; }

        public List<User> Guests { get; set; }
        public User Admin { get; set; }
        

    }
}
