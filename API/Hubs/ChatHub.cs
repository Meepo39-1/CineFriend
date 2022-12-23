using Domain.Rooms;
using Microsoft.AspNetCore.SignalR;

namespace API.Hubs

{
    public interface IRealTimeMessageService
    {
        //wait to talk with mentor
        //public Task SendMessage(Message message, string GroupName);

        public Task RecieveMessage(Message message);

    }


    public class ChatHub: Hub <IRealTimeMessageService>
    {
        public async Task SendMessageToGroupChat(Message message, string groupChatName)

            => await Clients.Group(groupChatName).RecieveMessage(message);

        
    }
}
