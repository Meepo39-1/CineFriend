using Domain.Rooms;
using Microsoft.AspNetCore.SignalR;

namespace API.Hubs

{
   
    public class ChatHub: Hub <Application.Services.IRealTimeMessageService>
    {
        public async Task SendMessage(Message message)

        => await Clients.All.RecieveMessage(message);
    }
}
