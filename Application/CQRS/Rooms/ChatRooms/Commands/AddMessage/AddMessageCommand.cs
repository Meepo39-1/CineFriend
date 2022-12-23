using Domain.Rooms;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Rooms.ChatRooms.Commands.AddMessage
{
    public class AddMessageCommand : IRequest<bool>
    {
        public Message message;

        
    }
}
