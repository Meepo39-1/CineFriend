using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CineFiend.Entities.Users
{
    internal class Guest : User 
    {   
        Guest(int id)
        {
            ID = id;
        }
        
        public override void MakeFriendRequest(int ID)
        {
            throw new NotImplementedException();
        }

        public override void MakeFriendRequest(string name)
        {
            throw new NotImplementedException();
        }
        public override void HandleFriendRequest(string name)
        {
            throw new NotImplementedException();
        }

        public override void WatchMovie(string name)
        {
            throw new NotImplementedException();
        }

        public override void HandleFriendRequest(int id)
        {
            throw new NotImplementedException();
        }

        public void WriteChat(string message)
        {
            //to be implemented
        }

        public void Connect (string link)
        {
            //to be implemented
        }

       
    }
}
