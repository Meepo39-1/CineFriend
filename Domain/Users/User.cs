using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Movies;
using Application.Interfaces;
using Domain.Rooms;


namespace Domain.Users;

    public class User 
    {
        public readonly MovieLibrary movies;
        public string ID { get; set; }
        public string Name { get; set; }
        public int StartYear { get; set; }
        protected string Password { get; set; }
        public int movieLibraryLength;
        public List<string> interests { get; set; }
    public int age;
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

        public abstract User Clone();
    }

