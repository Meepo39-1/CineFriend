using Application.Repositorys.Rooms;
using Domain.Rooms;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Rooms.CinemaRooms.Queries
{
    public class getInvitationsCommandHandler : IRequestHandler<getInvitationsCommand, List<GuestCinemaRoomInvitation>>
    {
        private readonly IGuestCinemaRoomInvitationRepository _inviteRepo;

        public getInvitationsCommandHandler(IGuestCinemaRoomInvitationRepository inviteRepo)
        {
            _inviteRepo = inviteRepo;
        }

        public async Task<List<GuestCinemaRoomInvitation>> Handle(getInvitationsCommand request, CancellationToken cancellationToken)
        {
            return await _inviteRepo.GetInvites(request.UserId);   
        }
    }
}
