using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Movies.MovieLibraries.Commands.UploadMovie
{
    public class MovieDTO
    {
        public string NAME { get; set; }
        public byte[] movieData { get; set; }
    }
}
