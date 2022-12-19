using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Movies;
using Application.Interfaces;
using Domain.Rooms;
using Infrastructure.EntityFrameworkDatabase.Models.Rooms;
using CinemaRoom = Infrastructure.EntityFrameworkDatabase.Models.Rooms.CinemaRoomType;
using Infrastructure.EntityFrameworkDatabase.Models.Movies;

namespace Infrastructure.EntityFrameworkDatabase.Models.Users
{
    public class UserType
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }


        //1 to 1
        public MovieLibraryType MovieLibrary { get; set; }

        //1 to 1
        public CinemaRoomType AdminCinema { get; set; }

        //many to many
        public ICollection<GuestCinemaRoomInvitation>? guestCinemas { get; set; }


    }
}

