
using Domain.Rooms.Chats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositorys.Rooms
{
    public interface IChatRepository
    {
        public void CreateChat();
        public Chat GetChat(string adminID);
    }
}
