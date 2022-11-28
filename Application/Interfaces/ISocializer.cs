using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ISocializer
    {
        public void AddFriend(string friendName);

        public void AddFriend(int friendId);
        public void RemoveFriend(string friendName);

        public void RemoveFriend(int friendId);

        
    }
}
