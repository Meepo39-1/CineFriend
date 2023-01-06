using Domain.Rooms;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Rooms.CinemaRooms.Queries
{
    public class getInvitationsCommand : IRequest<List<GuestCinemaRoomInvitation>>
    {
        public int UserId { get; set; }
    }
}
