using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Movies;
using Application.Interfaces;
using Domain.Rooms;


namespace Domain.Users
{
    public abstract class User : ICloneable, IWatcher, ISocializer, IChatter
    {
        public  readonly MovieLibrary movies;
        public string ID { get; set; }
        public string Name { get; set; }
        
        protected string Password { get; set; }
        public MovieLibrary Movies { get; }

        public FriendList Friends { get; }

        public User(string id = "NULL", string name = "NULL", string password = "NULL", MovieLibrary movies = null, FriendList friends = null)
        {
            ID = id;
            Name = name;
            Password = password;
            MovieLibrary copiedMovies = new MovieLibrary();
            foreach(Movie movie in movies)
            {
                copiedMovies.AddMovie(movie);

            }
            Movies = copiedMovies;

            FriendList copiedFriends = new FriendList();
            foreach (User friend in friends)
            {
                copiedFriends.AddFriend(friend);

            }

            friends = copiedFriends;

        }

        public abstract object Clone();

        public abstract void WatchMovie(int movieId);
        public abstract void WatchMovie(string movieName);
        public abstract void AddFriend(string friendName);
        public abstract void AddFriend(int friendId);
        public abstract void RemoveFriend(string friendName);
        public abstract void RemoveFriend(int friendId);
        public abstract void WriteMessage(string message);

        public virtual void SeeFriends()
        {
            foreach (User friend in Friends)
            {
                Console.WriteLine(friend.Name);
            }
        }
    }
}
