using Application.Repositorys.Rooms;
using Domain.Rooms;
using Infrastructure.EntityFrameworkDatabase.Models.Rooms;
using Infrastructure.EntityFrameworkDataBase.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EFRepositoryies.Rooms
{
    public class EFCoreMessageRepository : IMessageRepository
    {
        ApplicationDbContext _dbContext;
        public EFCoreMessageRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> CreateMessage(Message message)
        {
            var messageRecord = new MessageType();
            messageRecord.DateTime = message.DateTime;
            messageRecord.ChatId = message.Chat.Id;
            messageRecord.Content = message.Content;
            messageRecord.Sender = message.Sender;

           _dbContext.Messages.Add(message);
           _dbContext.SaveChanges();

            return true; 

        }

        public Task<bool> DeleteMessage(Message message, int chatId)
        {
            var messageRecord = _dbContext.Messages.First(m => m.Id == message.Id);

            _dbContext.Messages.Remove(messageRecord);
            _dbContext.SaveChanges();

            return Task.FromResult(true);

        }

        public Task<Message> UpdateMessage(Message message)
        {
            var messageRecord = _dbContext.Messages.First(m => m.Id == message.Id);

            messageRecord.DateTime = message.DateTime;
            messageRecord.ChatId = message.Chat.Id;
            messageRecord.Content = message.Content;
            messageRecord.Sender = message.Sender;

            _dbContext.Update(messageRecord);

            _dbContext.SaveChanges();

            var domainMessage = new Message();
            domainMessage.Id = messageRecord.Id;
            domainMessage.DateTime = messageRecord.DateTime;
            domainMessage.Chat.Id = messageRecord.ChatId;
            domainMessage.Content = messageRecord.Content;
            domainMessage.Sender = messageRecord.Sender;


            return Task.FromResult(domainMessage);

        }
    }
}
