using Domain.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositorys.Rooms
{
    public interface IChatRepository
    {
        public Task<int> CreateChat(CinemaRoom cinemaRoom);
        public Task<bool> DeleteChat(int chatId);

        public Task<Chat> GetChat(int chatId);
    }
}
