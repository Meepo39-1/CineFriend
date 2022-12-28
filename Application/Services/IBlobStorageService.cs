using Domain.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IBlobStorageService
    {
        public Task<string> UploadMovieToCloud(Movie movie);
        public Task<string> UploadMovieToCloud(byte[] movieData, string movieName);
    }
}
