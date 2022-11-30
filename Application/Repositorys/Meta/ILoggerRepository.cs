using Domain.Rooms.Cinema;
using Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositorys.Meta
{
    public interface ILoggerRepository
    {
        public List<User> GetUsers();
        public User GetMostActiveUser();
        public List<CinemaRoom> GetActiveCinemaRoom();
    }
}
