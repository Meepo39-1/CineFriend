using Application.CQRS.Users.Commands.CreateUser;
using Application.CQRS.Users.Commands.DeleteUser;
using Application.CQRS.Users.Commands.UpdateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using UserDTO = Application.CQRS.Users.Commands.CreateUser.UserDTO;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,  IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
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
       [HttpGet(Name = "GetWeatherForecast")]
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

        }*/
        
        [HttpGet(Name = "GetWeatherForecast")]
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