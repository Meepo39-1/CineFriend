using Application.Repositorys.Rooms;
using Domain.Rooms;
using Infrastructure.EntityFrameworkDatabase.Models.Rooms;
using Infrastructure.EntityFrameworkDataBase.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EFRepositoryies.Rooms
{
    public class EFCoreChatRepository : IChatRepository
    {
        private ApplicationDbContext _dbContext;

        public EFCoreChatRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<int> CreateChat(CinemaRoom cinemaRoom)
        {
            var newChatRecord = new ChatRoomType();
            newChatRecord.CinemaRoomTypeId = cinemaRoom.Id;

            _dbContext.Add(newChatRecord);
            _dbContext.SaveChanges();

            return Task.FromResult(newChatRecord.Id);
        }

        public Task<bool> DeleteChat(int chatId)
        {
            throw new NotImplementedException();
        }

        public Task<Chat> GetChat(int chatId)
        {
            var chatRecord = _dbContext.ChatRooms.First(c => c.Id == chatId);

            var newDomainChat = new Chat();
            var domainMessages = new List<Message>();
            

            foreach(var recordMessage in chatRecord.Messages)
            {
                var domainMessage = new Message();
                domainMessage.Id = recordMessage.Id;
                domainMessage.Sender = recordMessage.Sender;
                domainMessage.Content = recordMessage.Content;
                domainMessage.DateTime = recordMessage.DateTime;
                domainMessages.Add(domainMessage);
            }
            newDomainChat.Messages = domainMessages;

            return Task.FromResult(newDomainChat);
        }
    } 
}
