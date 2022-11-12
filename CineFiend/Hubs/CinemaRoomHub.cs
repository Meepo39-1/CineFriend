using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace CineFiend.Hubs
{
    internal class CinemaRoomHub : Hub
    {
        ChatHub videoHub;
        VideoHub chatHub;
    }
}
