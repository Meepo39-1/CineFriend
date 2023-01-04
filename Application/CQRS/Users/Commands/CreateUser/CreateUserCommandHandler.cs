using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Users;
using Domain.Rooms;
using Application.Repositorys.Users;
using Application.Repositorys.Rooms;
using Application.Repositorys;
using System.Diagnostics;
using Domain.Movies;

namespace Application.CQRS.Users.Commands.CreateUser
{

    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
  

        public CreateUserCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(CreateUserCommand command, CancellationToken cancellationToken)
        {   
                //mapping DTO to domain entity values ->will modify after implementing controllers
                UserDTO userInfo = command.userInfo;
                var newUser = new User();
                var newCinema = new CinemaRoom();
                newUser.Name = userInfo.Name;
                newUser.Password = userInfo.Password;


                await _unitOfWork.BeginTransaction();

              

                //an User is composed of a MovieLibrary and a CinemaRoom
          
                var userId = await _unitOfWork.UserRepository.CreateUser(newUser);

                newUser.Id = userId;
                //generting movie library
                await _unitOfWork.MovieLibraryRepository.CreateMovieLibrary(newUser);


                //generating cinemaRoom where the created user is admin
                newCinema.UserId = userId;
                //newUser.Id = userId;


                //a cinemaRoom is composed of chatRoom and MoviePlayer

    
                var cinemaRoomId = await _unitOfWork.CinemaRoomRepository.CreateCinemaRoom(newCinema);

                newCinema.MoviePlayer = new MoviePlayer();
                newCinema.MoviePlayer.Language = "ROMANA";
                newCinema.MoviePlayer.CinemaRoomId = cinemaRoomId;
                
                await _unitOfWork.MoviePlayerRepository.CreateMoviePlayer(newCinema);

                newCinema.Chat = new Chat();
                await _unitOfWork.ChatRepository.CreateChat(newCinema);

            //saving changes if all commands worked       
            // await _unitOfWork.Save();
            await _unitOfWork.CommitTransaction();
                return true;
            
            /*catch (Exception ex)
            {
                throw ex;
                return false;
            }*/
         
            
        

        }
    }
}
