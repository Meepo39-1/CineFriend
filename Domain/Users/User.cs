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

    public int Id { get; set; }
    public string Name { get; set; }

    public string Password { get; set; }


    //1 to 1
    public MovieLibrary MovieLibrary { get; set; }

    //1 to 1
    public CinemaRoom AdminCinema { get; set; }

    //many to many
    public ICollection<GuestCinemaRoomInvitation>? guestCinemas { get; set; }
}

