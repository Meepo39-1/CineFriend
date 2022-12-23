using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Rooms;
using Microsoft.AspNet.SignalR;

namespace Application.Services
{
    public interface IRealTimeMessageService
    {
        //wait to talk with mentor
        //public Task SendMessage(Message message, string GroupName);

        public Task SendMessageToGroupChat(Message message);

    }
   
}
 