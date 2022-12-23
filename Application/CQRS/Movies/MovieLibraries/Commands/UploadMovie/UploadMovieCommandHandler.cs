using Application.Repositorys;
using Application.Services;
using Domain.Movies;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Movies.MovieLibraries.Commands.UploadMovie
{
    public class UploadMovieCommandHandler : IRequestHandler<UploadMovieCommand, string>

    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileDownloadService _fileDownloadService;
        private readonly IBlobStorageService _blobStorageService;
        public UploadMovieCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<string> Handle(UploadMovieCommand request, CancellationToken cancellationToken)
        {
            var movie = new Movie();
            movie.Location = _fileDownloadService.DownloadMovieFromLocation(request.RequestedMovie.Location);

            _unitOfWork.BeginTransaction();
            //_unitOfWork.MovieRepository().CreateMovie(movie);
            _blobStorageService.UploadMovieToCloud(movie);
            _unitOfWork.CommitTransaction();

            return Task.FromResult("string location");
        }
    }
}
