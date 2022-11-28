using Application.Interfaces;
using Domain.Users;

namespace Application.Repositorys.Users
{
    public interface IUserRepository : ISocializer, IWatcher
    {
        void CreateUser(User newUser);
        void UpdateUser(int userID);
        void UpdateUser(string userID, List<string> params)

        void DeleteUser(int userID);
        void DeleteUser(string userID);

        User GetUser(int userID);
        IEnumerable<User> GetUsers();
        FriendList GetFriendList();
        User GetFriend();
    }
}