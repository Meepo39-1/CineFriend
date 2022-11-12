using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineFiend.Entities.Movies
{
   
    internal class MovieLibrary : IEnumerable
    {
        protected Movie[] movies = new Movie[1];

        MovieLibrary()
        {
            movies[0] = new Movie(1, "TopGun", "actiune", "100", 9);
        }
      
        public IEnumerator GetEnumerator()
        {
            return movies.GetEnumerator();

        }
    }
}
