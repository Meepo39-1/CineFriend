using Domain.Movies;
using Domain.Users;
using Infrastructure.EntityFrameworkDatabase.Models.Movies;
using Infrastructure.EntityFrameworkDatabase.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviePlayerType = Infrastructure.EntityFrameworkDatabase.Models.Movies.MoviePlayerType;

namespace Infrastructure.EntityFrameworkDatabase.Models.Rooms
{ 
    public class CinemaRoomType
    {
        public int Id { get; set; } 
        //1 TO 1
        public MoviePlayerType MoviePlayer { get; set; }
        //1 TO 1
        public ChatRoomType Chat { get; }

        //Many to many
        public ICollection<GuestCinemaRoomInvitation>? Guests { get; set; }

        //1 TO 1
        public int UserTypeId { get; set; }
        public Users.UserType Admin { get; set; }
        

    }
}
