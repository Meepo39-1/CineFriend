using Domain.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    internal interface IFileDownloadService
    {
        /*method that return the location of the downloaded file*/
        public string DownloadMovieFromLocation(string downloadPath);
    }
}
