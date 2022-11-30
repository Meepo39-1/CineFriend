using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositorys.Movies
{
    public interface IMovieLibraryRepository
    {
        void CreateMovieLibrary();
        void GetMovieLibrary();
    }
}
