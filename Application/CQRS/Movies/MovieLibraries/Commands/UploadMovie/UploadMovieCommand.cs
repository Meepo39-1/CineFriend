using Application.Repositorys;
using Domain.Movies;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Movies.MovieLibraries.Commands.UploadMovie
{
    public class UploadMovieCommand : IRequest<string>
    {
      
     
        public Movie RequestedMovie { get; set; }
    }
}
