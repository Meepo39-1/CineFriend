using Application.CQRS.Users.Commands.CreateUser;
using Application.Repositorys.Rooms;
using Application.Repositorys.Users;
using Domain.Exceptions;
using Domain.Movies;
using Domain.Users;
using MediatR;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTests.CQRS.Users.Commands
{
    [TestFixture]
    public class CreateUserCommandHandlerFixture
    {
        private Mock<IUserRepository> _fakeUserRepository;
        private Mock<ICinemaRoomRepository> _fakeRoomRepository;


        [SetUp]
        public void CreateFakeDependencys()
        {
            _fakeUserRepository = new Mock<IUserRepository>();
            _fakeRoomRepository = new Mock<ICinemaRoomRepository>();
        }

        [TestCase("George")]
        [TestCase("Mihai")]
        [TestCase("Eduard")]
        public async Task Handle_ValidNameUser_ReturnsSameName(string inputName)
        {
            //Arrange
            var fakeUser = new UserDTO
            {
                Name = inputName
            };
            var cancellationToken = new CancellationToken();

            var command = new CreateUserCommand
            {
                userInfo = fakeUser
            };

            var handler = new CreateUserCommandHandler(_fakeUserRepository.Object, _fakeRoomRepository.Object);

            //Act
            var resultName = await handler.Handle(command, cancellationToken);

            //Assert
            Assert.That(resultName == inputName);

        }


        [TestCase("@3123")]
        [TestCase("2424dsa,,.")]
        public async Task Handle_InvalidNameUser_ReturnsSameName(string inputName)
        {
            //Arrange
            bool invalidName = false;
            var userData = new UserDTO
            {
                Name = inputName
            };
            var cancellationToken = new CancellationToken();

            var command = new CreateUserCommand
            {
                userInfo = userData
            };

            var handler = new CreateUserCommandHandler(_fakeUserRepository.Object, _fakeRoomRepository.Object);

            //Act
            try
            {
                await handler.Handle(command, cancellationToken);
            }
            catch(InvalidNameException ex)
            {
                invalidName = true;
            }
            //Assert
            Assert.That(invalidName == true);
          
        }

    }
}
