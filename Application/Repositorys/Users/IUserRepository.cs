using Application.Interfaces;
using Domain.Users;

namespace Application.Repositorys.Users
{
    public interface IUserRepository 
    {
        public Task<int> CreateUser(User newUser);
        // public Task<bool> UpdateUser(int userID);
        // public Task<bool> UpdateUser(string userID, List<string> changes);
        public Task<bool> UpdateUser(User newUser);
        public Task<bool> DeleteUser(int userId);
       // public Task<bool> DeleteUser(string userID);

        public Task<User>  GetUser(int userId);
        //public Task<IEnumerable<User>>  GetUsers();

       /*
        * These methods will be implemented after mvp release
        */

       //public Task<User> FriendList GetFriendList();
       //public Task<User> User GetFriend();
    }
}