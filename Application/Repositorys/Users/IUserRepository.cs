using Application.Interfaces;
using Domain.Users;

namespace Application.Repositorys.Users
{
    public interface IUserRepository : ISocializer
    {
        void CreateUser(User newUser);
       // void UpdateUser(int userID);
        void UpdateUser(string userID);

        void DeleteUser(int userID);
        void DeleteUser(string userID);

        User GetUser(int userID);
        IEnumerable<User> GetUsers();
        FriendList GetFriendList();
        User GetFriend();
    }
}