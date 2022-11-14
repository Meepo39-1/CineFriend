using Domain.Movies;
using Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Rooms
{
    internal class CinemaRoom
    {
        Movie Movie { get; }
        Chat Chat { get; }

        List<Guest> Guests { get; set; }
        Admin Admin { get; set; }

    }
}
