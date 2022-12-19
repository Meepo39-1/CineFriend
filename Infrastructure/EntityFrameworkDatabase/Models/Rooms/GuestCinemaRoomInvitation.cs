using Infrastructure.EntityFrameworkDatabase.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityFrameworkDatabase.Models.Rooms
{
    public class GuestCinemaRoomInvitation
    {
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public DateTime ExpirationDate { get; set; }

        public CinemaRoomType? CinemaRoom { get; set; }
        public int? CinemaRoomTypeId { get; set; }

        public UserType? User { get; set; }
        public int? UserTypeId { get; set; }
    }
}
