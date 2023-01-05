using Domain.Movies;
using Domain.Users;

namespace Domain.Rooms
{
    public class CinemaRoom
    {
        public int Id { get; set; }
        //1 TO 1
        public MoviePlayer MoviePlayer { get; set; }
        //1 TO 1
        public Chat Chat { get; set; }

        //Many to many


        public ICollection<GuestCinemaRoomInvitation>? Guests { get; set; }

        //1 TO 1
        public int UserId { get; set; }
        public User Admin { get; set; }


    }
}
