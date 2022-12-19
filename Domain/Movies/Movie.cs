using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Movies
{
    public class Movie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        
        public string Genre { get; set; }
        public string Length { get; set; }
        public int Rating { get; set; }


    }
}
