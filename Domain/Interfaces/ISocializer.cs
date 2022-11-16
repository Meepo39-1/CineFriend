using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    internal interface ISocializer
    {
        void AddFriend(string friendName);

        void AddFriend(int friendId);
        void RemoveFriend(string friendName);

        void RemoveFriend(int friendId);

        
    }
}
