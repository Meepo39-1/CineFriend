using Domain.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositorys.Rooms
{
    public interface IMessageRepository
    {
        public Task<bool> CreateMessage(Message message);

        public Task<bool> DeleteMessage(Message message, int chatId);

        public Task<Message> UpdateMessage(Message message);
    }
}
