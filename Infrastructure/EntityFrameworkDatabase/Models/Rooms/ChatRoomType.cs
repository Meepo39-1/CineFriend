using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure.EntityFrameworkDatabase.Models.Rooms
{
    public class ChatRoomType
    {
        //1 to many
        public int Id { get; set; } 
        public List<MessageType>? Messages { get; set; }

        

        public int CinemaRoomTypeId { get; set; }
        public CinemaRoomType CinemaRoom { get; set; }
    }
}
