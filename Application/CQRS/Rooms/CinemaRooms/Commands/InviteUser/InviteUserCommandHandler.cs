using Application.Repositorys.Rooms;
using Domain.Rooms;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Rooms.CinemaRooms.Commands.InviteUser
{
    public class InviteUserCommandHandler : IRequestHandler<InviteUserCommand, bool>
    {
        private readonly IGuestCinemaRoomInvitationRepository _invitationRepo;

        public InviteUserCommandHandler(IGuestCinemaRoomInvitationRepository invitationRepo)
        {
            _invitationRepo = invitationRepo;
        }

        public async Task<bool> Handle(InviteUserCommand request, CancellationToken cancellationToken)
        {
            GuestCinemaRoomInvitation inviteModel = request.Invitation;
            await _invitationRepo.DeleteExpiredInvitations();
            return await _invitationRepo.CreateInvite(inviteModel);
        }
    }
}
