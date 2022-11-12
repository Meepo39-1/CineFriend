using CineFiend.Entities.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineFiend.Entities.Movies;
using System.Reflection.Metadata;
using CineFiend.Entities.Users;

namespace CineFiend.Entities.Users
{
    internal abstract class User : IWatcher, ISocializer,ICloneable
    {
        protected int _ID;
        protected string _emailAdress, password;
        protected MovieLibrary _movieLibrary;
        protected List<User> _friendList;

        public int ID { get { return _ID; }
            set { _ID = value; }
       }
        public MovieLibrary MovieLibrary { get { return _movieLibrary; } }

        public List<User> FriendList { get { return _friendList; } }


        public abstract void WatchMovie(string name);
     
        public abstract void MakeFriendRequest(int ID);
        public abstract void MakeFriendRequest(string name);

        public abstract void HandleFriendRequest(string name);
        public abstract void HandleFriendRequest(int id);
        public object Clone()
        {
            var clone = (User) this.MemberwiseClone();
            HandleClone(clone);
            return this;
        }
        public virtual void HandleClone(User clone)
        {
            //method usefull for children 
        }


    }
}
