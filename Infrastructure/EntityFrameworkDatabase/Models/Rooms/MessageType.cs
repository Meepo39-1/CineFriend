using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityFrameworkDatabase.Models.Rooms
{
    public class MessageType
    { 
        public int Id { get; set; }

        public string Content { get; set; }
        public int ChatId { get; set; }
        public ChatRoomType Chat { get; set; }
    }
}
