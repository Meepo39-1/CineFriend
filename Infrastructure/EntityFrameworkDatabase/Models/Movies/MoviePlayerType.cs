using Domain.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.EntityFrameworkDatabase.Models.Rooms;

namespace Infrastructure.EntityFrameworkDatabase.Models.Movies
{   

    public class MoviePlayerType
    {
        public int Id { get; set; }

        public string Language { get; set; }
        

        
        public int CinemaRoomTypeId { get; set; }
        public CinemaRoomType CinemaRoom { get; set; }

        
    }
}
