using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Movies
{
    internal class MovieLibrary : IEnumerable
    {
        List<Movie> _movies;

        public IEnumerator GetEnumerator()
        {
            return _movies.GetEnumerator();
        }

        
    }
}
