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
    public class MessageController : Controller
    {
        private readonly IMediator _mediator;
        public IHubContext<ChatHub, IRealTimeMessageService> _chatHubContext { get; } //?

        public IHubContext<VideoHub, IVideoHub> _videoHubContext { get; }
        public MessageController(IMediator mediator, IHubContext<ChatHub, IRealTimeMessageService> chatHubContext, IHubContext<VideoHub, IVideoHub> VideoHubContext)
        {
            _mediator = mediator;
            _chatHubContext = chatHubContext;
            _videoHubContext = VideoHubContext;
        }

        [HttpPost(Name = "GetCreateMessage")]
        public async Task<string> CreateMessage(string user, string content)
        {
            var messageFromRequest = new Message
            {
                Sender = user,
                Content = content,
                ChatId = 1
            };


            var message = await _mediator.Send(new AddMessageCommand
            {
                message = messageFromRequest
            });


            if (message)
            {
                await SendMessageToGroupChat(messageFromRequest, "GroupTest");
            }
            return message.ToString();
        }


        [NonAction]
        public async Task SendMessageToGroupChat(Message message, string groupChatName)

            => await _chatHubContext.Clients.Group(groupChatName).RecieveMessage(message);
    }
}
