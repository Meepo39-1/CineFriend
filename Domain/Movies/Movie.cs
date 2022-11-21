using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Movies
{
    public class Movie: ICloneable
    {
        public Movie(int iD, string name, string genre, int rating)
        {
            ID = iD;
            Name = name;
            Genre = genre;
            Rating = rating;
        }

        int ID { get; set; }
        public string Name { get; set; }
        
        string Genre { get; set; }
        string Length { get; set; }
        int Rating { get; set; }

        public object Clone()
        {
            return new Movie(ID, Name, Genre, Rating);
        }
    }
}
