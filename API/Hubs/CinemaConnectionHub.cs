using Microsoft.AspNetCore.SignalR;

namespace API.Hubs
{
    public interface IVideoHub
    {
       public Task AddToGroup(string groupName);
   
    }

    public class VideoHub : Hub<IVideoHub>
    {

        //numele grupului va fi furnizat de catre frontend
        public Task AddToGroup(string groupName)
               => Groups.AddToGroupAsync(Context.ConnectionId, groupName);

        //To be authorized only for the admin of the group
        public Task UpdateTime(string groupName)
              => Groups.AddToGroupAsync(Context.ConnectionId, groupName);

    }
}
