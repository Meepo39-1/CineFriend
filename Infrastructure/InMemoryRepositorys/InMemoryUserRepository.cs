using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;
using Domain.Users;
using Domain.Movies;
using Application.Repositorys.Users;

namespace Infrastructure.InMemoryRepositorys
{
    public class InMemoryUserRepository  //:IUserRepository
    {
       /* List<User> users = new List<User>()
        {
            new User("1","George", "parola1", new MovieLibrary(), new FriendList()),
            new User("2","Mihai", "parola2", new MovieLibrary(), new FriendList()),
            new User("3","Cosmin", "parola3", new MovieLibrary(), new FriendList()),
        };*/

        public void AddFriend(string friendName)
        {
            throw new NotImplementedException();
        }

        public void AddFriend(int friendId)
        {
            throw new NotImplementedException();
        }

        public void CreateUser(User userInfo)
        {
            //users.Append(userInfo);
            
        }

        public void DeleteUser(int userID)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(string userID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllFriends()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetFriend()
        {
            throw new NotImplementedException();
        }

        public FriendList GetFriendList()
        {
            throw new NotImplementedException();
        }

        public User GetUser(int userID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void RemoveFriend(string friendName)
        {
            throw new NotImplementedException();
        }

        public void RemoveFriend(int friendId)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(int userID)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(string userID, List<string> changes)
        {
            throw new NotImplementedException();
        }

        public void WatchMovie(int movieId)
        {
            throw new NotImplementedException();
        }

        public void WatchMovie(string movieName)
        {
            throw new NotImplementedException();
        }
    }
    
}
