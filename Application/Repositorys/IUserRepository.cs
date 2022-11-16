using Domain.Users;

namespace Application.Repositorys
{
    public interface IUserRepository
    {
        void CreateUser(User userv1, User userv2);
        void UpdateUser(int userID);

        void DeleteUser(int userID);

        User GetUser(int userID);

        IEnumerable<User> GetAllUsers();
    }
}