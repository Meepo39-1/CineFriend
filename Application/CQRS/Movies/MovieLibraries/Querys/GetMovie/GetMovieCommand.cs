using Domain.Movies;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Movies.MovieLibraries.Querys.GetMovie
{
     public class GetMovieCommand: IRequest<string>
    {
        public int MovieId { get; set; }
    }
}
