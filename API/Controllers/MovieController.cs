using API.Hubs;
using Application.CQRS.Rooms.ChatRooms.Commands.AddMessage;
using Application.Services;
using Domain.Rooms;
using MediatR;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using IRealTimeMessageService = API.Hubs.IRealTimeMessageService;

namespace API.Controllers
{
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private readonly IMediator _mediator;
        public IHubContext<ChatHub, IRealTimeMessageService> _chatHubContext { get; } //?

        public IHubContext<CinemaConnectionHub, ICinemaConnectionHub> _cinemaConnectionHubContext { get; }
        public MovieController(IMediator mediator, IHubContext<ChatHub, IRealTimeMessageService> chatHubContext, IHubContext<CinemaConnectionHub, ICinemaConnectionHub> cinemaConnectionHubContext)
        {
            _mediator = mediator;
            _chatHubContext = chatHubContext;
            _cinemaConnectionHubContext = cinemaConnectionHubContext;
        }

        [HttpGet(Name = "UploadMovie")]
        public async Task<string> CreateMessage()
        {
            var messageFromRequest = new Message
            {
                Sender = "Edi",
                Content = "Buna",
                Chat = new Chat { Id = 2 }
            };


            var message = await _mediator.Send(new AddMessageCommand
            {
                message = messageFromRequest
            });


            if (message)
            {
                // await SendMessageToGroupChat(messageFromRequest, User.Identity.Name);
            }
            return message.ToString();
        }

        [NonAction]
        public async Task SendMessageToGroupChat(Message message, string groupChatName)

            => await _chatHubContext.Clients.Group(groupChatName).RecieveMessage(message);
    }
}
