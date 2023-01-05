using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Rooms.CinemaRooms.Commands.ProcessInvite
{
    public class ProcessInviteCommand : IRequest<bool>
    {
        public InvitationDTO Invitation { get; set; }
    }
}
