using Domain.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Rooms
{
    public class GuestCinemaRoomInvitation
    {
       
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTimeOffset Date { get; set; }
        public DateTimeOffset ExpirationDate { get; set; }

        public CinemaRoom CinemaRoom { get; set; }
        public int? CinemaRoomId { get; set; }

        public User? User { get; set; }
        public int? UserId { get; set; }
    }
}
