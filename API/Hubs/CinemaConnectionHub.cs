using Microsoft.AspNetCore.SignalR;

namespace API.Hubs
{
    public interface ICinemaConnectionHub
    {
       public Task AddToGroup(string groupName);
   
    }

    public class CinemaConnectionHub : Hub<ICinemaConnectionHub>
    {

        public Task AddToGroup(string groupName)
               => Groups.AddToGroupAsync(Context.ConnectionId, groupName);


    }
}
