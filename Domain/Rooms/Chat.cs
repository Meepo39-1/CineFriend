using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Rooms
{
    public class Chat
    {
        //1 to many
        public int Id { get; set; }
        public List<Message>? Messages { get; set; }



        public int CinemaRoomId { get; set; }
        public CinemaRoom CinemaRoom { get; set; }

    }
}
