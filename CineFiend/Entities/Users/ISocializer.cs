using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineFiend.Entities.Users
{
    internal interface ISocializer
    {
        void MakeFriendRequest(int ID);
        void MakeFriendRequest(string name);

        void HandleFriendRequest(int ID);
        void HandleFriendRequest(string name);
    }
}
