using Application.CQRS.Movies.MovieLibraries.Commands.UploadMovie;
using Application.Repositorys;
using Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Movies.MovieLibraries.Querys.GetMovie
{
    public class GetMovieCommandHandler : IRequestHandler<GetMovieCommand, byte[]>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileDownloadService _fileDownloadService;
        private readonly IBlobStorageService _blobStorageService;
        public GetMovieCommandHandler(IUnitOfWork unitOfWork, IFileDownloadService fileDownloadService, IBlobStorageService blobStorageService)
        {
            _unitOfWork = unitOfWork;
            _fileDownloadService = fileDownloadService;
            _blobStorageService = blobStorageService;
        }
        public async Task<byte[]> Handle(GetMovieCommand request, CancellationToken cancellationToken)
        {
           
       
            try
            {
                
                _unitOfWork.BeginTransaction();
                var movie = await _unitOfWork.MovieRepository.GetMovie(request.MovieId);
                var movieData = await _blobStorageService.DownloadMovie(movie);

                _unitOfWork.CommitTransaction();
                return movieData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }
    }

}
