using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineFiend.Entities.Users
{
    internal class Admin : User
    {
        public Admin(int cod) : base()
        {
            ID = cod;

        }
        public override void WatchMovie(string name)
        {
            Console.WriteLine("Watching movie");
        }
        public override void HandleFriendRequest(string name)
        {
            Console.WriteLine("Handling Friend Request");
        }
        public override void MakeFriendRequest(string name)
        {
            Console.WriteLine("Making Friend Request to name");
        }
        public override void MakeFriendRequest(int id)
        {
            Console.WriteLine("Making Friend Request to id");
        }

        public override void HandleFriendRequest(int id)
        {
            throw new NotImplementedException();
        }

       
    }
}
