using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users
{
    internal class FriendList: IEnumerable
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

       
    }
}
