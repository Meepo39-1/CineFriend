using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Movies;
using Application.Interfaces;
using Domain.Rooms;


namespace Domain.Users;

    public abstract class User 
    {
        protected readonly MovieLibrary movies;
        protected int ID { get; set; }
        protected string Name { get; set; }
        
        protected string Password { get; set; }
        protected MovieLibrary Movies { get; }

        protected FriendList Friends { get; }

        public User(string id = "NULL", string name = "NULL", string password = "NULL", MovieLibrary movies = null, FriendList friends = null)
        {
            ID = id;
            Name = name;
            Password = password;
            Movies = movies;
        }

        public abstract User Clone();
    }

