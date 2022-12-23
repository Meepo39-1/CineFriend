using API.Hubs;
using Application.CQRS.Rooms.ChatRooms.Commands.AddMessage;
using Application.CQRS.Users.Commands.CreateUser;
using Application.CQRS.Users.Commands.DeleteUser;
using Application.CQRS.Users.Commands.UpdateUser;
using Application.Services;
using Domain.Rooms;

using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using IRealTimeMessageService = API.Hubs.IRealTimeMessageService;
using UserDTO = Application.CQRS.Users.Commands.CreateUser.UserDTO;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;
        //THE TYPE CHAThUB -> can't be used as Thub in IHUBContext<Thub, T>

        public IHubContext<ChatHub, IRealTimeMessageService> _hubContext { get; } //?
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,  IMediator mediator, IHubContext<ChatHub, IRealTimeMessageService> chatHubContext)
        {
            _logger = logger;
            _mediator = mediator;
            _hubContext = chatHubContext;
        }

        /* [HttpGet(Name = "CreateUser")]
         public async Task<string> Get()
         {
             var userFromRequest = new UserDTO();
             userFromRequest.Name = "Mihai";
             userFromRequest.Password = "parola";

                var message = await _mediator.Send(new CreateUserCommand
                 {
                   userInfo = userFromRequest
                 });
             // _logger.LogDebug("!!!!!!1MEDIATOR CALLED!!!!!");

             return message.ToString();

         }
        */
        /*
        

         }*/

        /* [HttpGet(Name = "GetWeatherForecast")]
         public async Task<string> DeleteUser()
         {
             var userFromRequest = new Application.CQRS.Users.Commands.DeleteUser.UserDTO();
             userFromRequest.Id = 1007;

             var message = await _mediator.Send(new DeleteUserCommand
             {
                 userDTO = userFromRequest
             });
             // _logger.LogDebug("!!!!!!1MEDIATOR CALLED!!!!!");

             return message.ToString();

         }
        */
        
        [HttpGet(Name = "GetWeatherForecast")]
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
            // _logger.LogDebug("!!!!!!1MEDIATOR CALLED!!!!!");

            if (message)
            {
                SendMessageToUsers(messageFromRequest);
            }
            return message.ToString();

        }

        [NonAction]
        public async void SendMessageToUsers(Message message)
        {
            await _hubContext.Clients.All.RecieveMessage(message);
            
        }
        
    }
}