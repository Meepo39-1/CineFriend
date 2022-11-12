using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CineFiend.Entities.Movies
{
    internal class Movie 
    {   
      

        public int Id { get; set; }
        public string Name { get; set; }

        public string Genre { get; set; }

        public int Rating { get; set; }
        public string Lenght { get; set; }

        

        public Movie(int id, string name, string genre, string lenght, int rating)
        {
            Id = id;
            Name = name;
            Genre = genre;
            Lenght = lenght;
            Rating = rating;
        }

    }
}
