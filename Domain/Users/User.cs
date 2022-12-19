using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Movies;
using Domain.Rooms;


namespace Domain.Users;

    public class User 
    {
        public MovieLibrary movieLibrary { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Password { get; set; }
        

        //protected FriendList Friends { get; }

        public CinemaRoom adminCinema;

        public List<CinemaRoom> guestCinemas;

        

        //public abstract User Clone();
    }

