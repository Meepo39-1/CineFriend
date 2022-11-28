using Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Application.Repositorys.Users
{
    public interface IFriendListRepository : ISocializer
    {
        void CreateFriendList();
        User GetFriends(string name);
        void AddFriend(User user);
        void RemoveFriend(User user);
    }
}
