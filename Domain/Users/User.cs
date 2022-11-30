﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Movies;
using Domain.Rooms.Cinema;

namespace Domain.Users;

public class User 
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
    }

