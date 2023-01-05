using Application.CQRS.Rooms.CinemaRooms.Commands.InviteUser;
using Application.CQRS.Rooms.CinemaRooms.Commands.ProcessInvite;
using Domain.Rooms;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace API.Controllers
{
    [Route("[controller]")]
    public class InvitationController : Controller
    {   
        private readonly IMediator _mediator;
        //THE TYPE CHAThUB -> can't be used as Thub in IHUBContext<Thub, T>

        public InvitationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("/createInvite", Name = "InviteUser")]
        //only admin can do that, wait for authorization
        public async Task<bool> CreateInvitation(int cinemaId, int userId)
        {
            var invitationDTO = new GuestCinemaRoomInvitation();
            invitationDTO.UserId = userId;
            invitationDTO.CinemaRoomId = cinemaId;
            invitationDTO.Date = DateTimeOffset.Now;
            invitationDTO.ExpirationDate = DateTimeOffset.Now.AddDays(1);
            invitationDTO.Status = "pending";

            var inviteCommand = new InviteUserCommand()
            {
                Invitation = invitationDTO
        };

            bool inviteCommandSucces = await  _mediator.Send(inviteCommand);
            return inviteCommandSucces;
        }

        [HttpPatch("/processInvite",Name ="RespondToInvite")]
        public async Task<bool> ProcessInvitation(int invitationId, string response)
        {
            var invitationDTO = new InvitationDTO()
            {
                Id = invitationId,
                Status = response
            };

            var processInviteCommand = new ProcessInviteCommand()
            {
                Invitation = invitationDTO
            };

            bool processCommandSucces = await _mediator.Send(processInviteCommand);
            return processCommandSucces;
        }
    }
}
