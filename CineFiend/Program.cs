using CineFiend.Entities.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineFiend
{
    internal class Program
    {
        MovieLibrary library;

        void TestMethod()
        {
            foreach (Movie movie in library)
            {
                Console.WriteLine(movie.Name);
            }
        }
    }
}
