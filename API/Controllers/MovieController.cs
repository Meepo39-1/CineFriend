using API.Hubs;
using Application.CQRS.Movies.MovieLibraries.Commands.UploadMovie;
using Application.CQRS.Movies.MovieLibraries.Querys.GetMovie;
using Application.CQRS.Rooms.ChatRooms.Commands.AddMessage;
using Application.Services;
using Domain.Movies;
using Domain.Rooms;
using Domain.Users;
using MediatR;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

        [HttpPost("/upload", Name = "UploadMovie")]
        public async Task<string> UploadMovie(string reqMovieName, IFormFile formFile)
        {
            var fileReader = new BinaryReader(formFile.OpenReadStream());

            byte[] reqMovieData = fileReader.ReadBytes((int)formFile.Length);

            var movieFromRequest = new MovieDTO
            {
                NAME = reqMovieName,
                movieData = reqMovieData
              
            };
                       

            var message = await _mediator.Send(new UploadMovieCommand
            {
                Movie = movieFromRequest
            });


           
            return message.ToString();
        }
        [HttpGet("/getMovie", Name = "GetMovie")]
        public async Task<FileContentResult> GetMovie(int id)
        {

            var data = await _mediator.Send(new GetMovieCommand
            {
                MovieId = id
            });

            //return new FileContentResult(data, "video/mp4");
            return File(data, "video/mp4");
            //return data;
        }

        /*
        [HttpGet("/get", Name = "GetMovie")]
        public async Task<string> Movie(string reqLocation)
        {
            var movieFromRequest = new Movie
            {
                Name = "Over the Garden Wall",
                Location = reqLocation
            };


            var message = await _mediator.Send(new GetMovieCommand
            {
                RequestedMovie = movsieFromRequest
            });



            return message.ToString();
        }
        */
    }
}
