using API.Hubs;
using Application.CQRS.Users.Commands.CreateUser;
using Application.CQRS.Users.Commands.DeleteUser;
using Application.CQRS.Users.Commands.UpdateUser;
using Application.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using IRealTimeMessageService = API.Hubs.IRealTimeMessageService;
using UserDTO = Application.CQRS.Users.Commands.CreateUser.UserDTO;

namespace API.Controllers
{
    [Route("User")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IMediator _mediator;
        //THE TYPE CHAThUB -> can't be used as Thub in IHUBContext<Thub, T>


        public IHubContext<ChatHub, IRealTimeMessageService> _chatHubContext { get; } //?

       public UserController(IMediator mediator, IHubContext<ChatHub, IRealTimeMessageService> chatHubContext)
        {
            _mediator = mediator;
            _chatHubContext = chatHubContext;
         
        }


        [HttpPost("/CreateUser", Name = "CreateUser")]

       // [Route("User/CreateUser")]
        public async Task<string> CreateUser(string name, string password)
        {
            var userFromRequest = new UserDTO();
            userFromRequest.Name = name;
            userFromRequest.Password = password;

            var message = await _mediator.Send(new CreateUserCommand
            {
                userInfo = userFromRequest
            });


            //grupul user-ului va fi creat din frontend, adica se va accesa o noua ruta
            //intreaba mentorul daca e oke 

          
            return message.ToString();

        }

        [HttpGet("/UpdateUser", Name = "UpdateUser")]
        //[Route("User/UpdateUser")]
        public async Task<string> UpdateUser()
        {
            var userFromRequest = new Application.CQRS.Users.Commands.UpdateUser.UserDTO();
            userFromRequest.Id = 1007;
            userFromRequest.UserName = "Edi";
            userFromRequest.Password = "parola";

            var message = await _mediator.Send(new UpdateUserCommand
            {
                userInfo = userFromRequest
            });
            // _logger.LogDebug("!!!!!!1MEDIATOR CALLED!!!!!");

            return message.ToString();
        }

        [HttpGet("/DeleteUser", Name = "DeleteUser")]
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
    }
}
