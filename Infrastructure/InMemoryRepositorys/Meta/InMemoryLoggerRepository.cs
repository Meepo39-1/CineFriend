using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Repositorys.Meta;
using Domain.Meta;
using Domain.Rooms.Cinema;
using Domain.Users;

namespace Infrastructure.InMemoryRepositorys.Meta
{
    internal class InMemoryLoggerRepository : ILoggerRepository
    {
        static private Logger _logger = Logger.Instance; 
        public List<CinemaRoom> GetActiveCinemaRoom()
        {
            throw new NotImplementedException();
        }

        public User GetMostActiveUser()
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
