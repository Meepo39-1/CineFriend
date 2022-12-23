using Domain.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Movies
{   

    public class MoviePlayer
    {
       public int Id { get; set; }

        public string Language { get; set; }



        public int CinemaRoomId { get; set; }
        public CinemaRoom CinemaRoom { get; set; }

    }
}
