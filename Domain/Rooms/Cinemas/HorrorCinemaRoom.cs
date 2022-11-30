using Domain.Rooms.Chats;
using Domain.Rooms.Cinema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Rooms.Cinemas
{
    public class HorrorCinemaRoom : CinemaRoom
    {
        public override Chat CreateChat()
        {
            return new HorrorChat();
        }

    }
}
