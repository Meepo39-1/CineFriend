using Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Rooms
{
    public class GuestCinemaRoomInvitation
    {
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public DateTime ExpirationDate { get; set; }

        public CinemaRoom CinemaRoom { get; set; }
        public int? CinemaRoomId { get; set; }

        public User? User { get; set; }
        public int? UserId { get; set; }
    }
}
