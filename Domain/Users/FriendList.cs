using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users
{
    public class FriendList: IEnumerable
    {
        List<User> _friends;

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)_friends).GetEnumerator();
        }

        public void AddFriend(User user)
        {
            
            _friends.Add((User) user.Clone());
        }

        public void RemoveFriend(User user)
        {

            _friends.Remove((User)user.Clone());
        }


    }
}
