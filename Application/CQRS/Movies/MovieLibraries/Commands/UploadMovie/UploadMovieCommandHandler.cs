using Application.Repositorys;
using Application.Services;
using Domain.Movies;
using MediatR;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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
        public UploadMovieCommandHandler(IUnitOfWork unitOfWork, IFileDownloadService fileDownloadService, IBlobStorageService blobStorageService)
        {
            _unitOfWork = unitOfWork;
            _fileDownloadService = fileDownloadService;
            _blobStorageService = blobStorageService;
        }

        public async Task<string> Handle(UploadMovieCommand request, CancellationToken cancellationToken)
        {
            var movie = new Movie();
            movie.Name = request.Movie.NAME;
            //movie.Location = null;
            //byte[] movieData =  await _fileDownloadService.DownloadMovieFromLocation(request.RequestedMovie.Location);

            try
            {
                movie.Location = await _blobStorageService.UploadMovieToCloud(request.Movie.movieData, request.Movie.NAME);

                _unitOfWork.BeginTransaction();
                _unitOfWork.MovieRepository.CreateMovie(movie);
           
                _unitOfWork.CommitTransaction();
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return movie.Location;
        }
    }
}
