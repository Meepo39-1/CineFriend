using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Rooms.CinemaRooms.Commands.ProcessInvite
{
    public class InvitationDTO 
    {
        public int Id { get; set; }
        public string Status { get; set; }
    }
}
