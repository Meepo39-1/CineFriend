using Application.Repositorys.Rooms;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Rooms.CinemaRooms.Commands.ProcessInvite
{
    public class ProcessInviteCommandHandler : IRequestHandler<ProcessInviteCommand,bool>
    {
        private readonly IGuestCinemaRoomInvitationRepository _inviteRepo;
        public ProcessInviteCommandHandler(IGuestCinemaRoomInvitationRepository inviteRepo)
        {
            _inviteRepo = inviteRepo;
        }

        public Task<bool> Handle(ProcessInviteCommand request, CancellationToken cancellationToken)
        {
           


            return _inviteRepo.UpdateInvite(request.Invitation.Id, request.Invitation.Status);
        }
    }
}
