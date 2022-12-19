using Application.CQRS.Users.Commands.CreateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<string> Get()
        {
            var userFromRequest = new UserDTO();
            userFromRequest.Name = "George";
            userFromRequest.Password = "parola";
            
               var message = await _mediator.Send(new CreateUserCommand
                {
                  userInfo = userFromRequest
                });
            // _logger.LogDebug("!!!!!!1MEDIATOR CALLED!!!!!");

            return message.ToString();

        }
    }
}