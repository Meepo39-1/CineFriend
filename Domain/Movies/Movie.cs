using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Movies
{
    internal class Movie
    {
        int ID { get; set; }
        string Name { get; set; }
        
        string Genre { get; set; }
        string Length { get; set; }
        int Rating { get; set; }


    }
}
