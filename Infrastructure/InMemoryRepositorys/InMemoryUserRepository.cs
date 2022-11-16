using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;
using Application.Repositorys;
using Domain.Users;

namespace Infrastructure.InMemoryRepositorys
{
    public class InMemoryUserRepository : IUserRepository
    {
        public void CreateUser(User userv1, User userv2)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int userID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUser(int userID)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(int userID)
        {
            throw new NotImplementedException();
        }
    }
    {
    }
}
