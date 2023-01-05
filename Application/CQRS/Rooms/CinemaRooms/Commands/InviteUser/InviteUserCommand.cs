using Domain.Rooms;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Rooms.CinemaRooms.Commands.InviteUser
{
    public class InviteUserCommand : IRequest<bool>
    {
        public GuestCinemaRoomInvitation Invitation { get; set; }
    }
}
