using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Movies;
using Domain.Observer_Design_Pattern;
using Domain.Rooms.Cinema;

namespace Domain.Users;

public class User : Subscriber
    {
        protected readonly MovieLibrary movies;
        protected string ID { get; set; }
        protected string Name { get; set; }
        
        protected string Password { get; set; }
        protected MovieLibrary Movies { get; }

        protected FriendList Friends { get; }

        public CinemaRoom adminCinema;
        public CinemaRoom activeRoom;
        public List<CinemaRoom> guestCinemas;

        public User(string id = "NULL", string name = "NULL", string password = "NULL", MovieLibrary movies = null, FriendList friends = null)
        {
            ID = id;
            Name = name;
            Password = password;
            Movies = movies;
        }
    

        public User Clone() { return this; }

        public void Notify(string cinemaRoomId)
        {
        Console.WriteLine("Cinema room with" + cinemaRoomId + "has started watching a movie. Don't you wanna join?");
        }

        Task Subscriber.Notify(string context)
        {
        Console.WriteLine("Cinema room with" + cinemaRoomId + "has started watching a movie. Don't you wanna join?");

        return Task.CompletedTask;
    }
}

